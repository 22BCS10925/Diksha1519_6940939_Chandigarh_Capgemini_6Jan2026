# Payment Tracking Feature - Implementation Guide

## Overview
The payment tracking feature now allows automatic recording of payment transactions for both **patients** and **doctors** when a bill is paid.

## Database Changes

### New Model: Payment
- **Table**: `Payments`
- **Purpose**: Central record of all payment transactions
- **Relationships**:
  - Links to Billing (via BillingId)
  - Links to Patient (via PatientId)
  - Links to Doctor (via DoctorId)

### Updated Models

#### Patient
```csharp
public ICollection<Payment> Payments { get; set; } = new List<Payment>();
```
- Now tracks all payments made by the patient

#### Doctor
```csharp
public ICollection<Payment> Payments { get; set; } = new List<Payment>();
```
- Now tracks all payments received for their services

#### Billing
```csharp
public ICollection<Payment> Payments { get; set; } = new List<Payment>();
```
- Links all payments associated with a specific bill

## API Endpoints

### 1. Process Payment (Updated)
**POST** `/api/billings/pay`

#### Request Body
```json
{
  "billingId": 1,
  "amount": 500.00,
  "paymentMethod": "Cash",
  "notes": "Payment for appointment on 2026-04-06",
  "transactionId": "TXN123456789"
}
```

#### Response
```json
{
  "message": "Payment processed successfully",
  "paymentId": 1,
  "amount": 500.00,
  "paidAt": "2026-04-06T10:30:45.1234567Z"
}
```

#### When Payment is Processed:
1. ✅ Marks the Billing as `IsPaid = true`
2. ✅ Sets `PaidAt` timestamp on Billing
3. ✅ Creates a Payment record linked to:
   - The specific Billing
   - The Patient (from associated Appointment)
   - The Doctor (from associated Appointment)
4. ✅ Records payment method and additional details

---

### 2. Get Patient Payment History
**GET** `/api/billings/patient/{patientId}/payments`

#### Response
```json
{
  "patientId": 1,
  "totalPayments": 5,
  "totalAmount": 2500.00,
  "payments": [
    {
      "id": 1,
      "billingId": 10,
      "amount": 500.00,
      "paymentMethod": "Cash",
      "notes": "Payment for appointment",
      "transactionId": "TXN123456789",
      "paidAt": "2026-04-06T10:30:45Z"
    },
    ...
  ]
}
```

#### Use Cases:
- View all payments made by a patient
- Track payment history and amounts
- Generate patient billing statements
- Verify payment receipts

---

### 3. Get Doctor Payment History
**GET** `/api/billings/doctor/{doctorId}/payments`

#### Response
```json
{
  "doctorId": 1,
  "totalPayments": 8,
  "totalAmount": 4000.00,
  "payments": [
    {
      "id": 2,
      "billingId": 11,
      "amount": 500.00,
      "paymentMethod": "Card",
      "notes": "Payment from patient John Doe",
      "transactionId": "TXN987654321",
      "paidAt": "2026-04-05T09:15:30Z"
    },
    ...
  ]
}
```

#### Use Cases:
- View all payments received by a doctor
- Calculate total earnings
- Generate doctor income reports
- Track payment trends per doctor

---

## Data Flow Diagram

```
Patient Pays Bill
       ↓
[POST /api/billings/pay]
       ↓
   Billing Updated
   (IsPaid = true, PaidAt = now)
       ↓
   Payment Record Created
       ├─→ Link to Billing (BillingId)
       ├─→ Link to Patient (PatientId)
       └─→ Link to Doctor (DoctorId)
       ↓
Patient can view via:
[GET /api/billings/patient/{id}/payments]
       ↓
Doctor can view via:
[GET /api/billings/doctor/{id}/payments]
```

---

## Example Workflow

### Step 1: Patient Makes Appointment
1. Doctor and Patient have an appointment
2. Billing record is created with ConsultationFee + MedicineCost

### Step 2: Patient Pays Bill
```bash
curl -X POST http://localhost:5000/api/billings/pay \
  -H "Content-Type: application/json" \
  -d '{
    "billingId": 1,
    "amount": 500.00,
    "paymentMethod": "Card",
    "transactionId": "TXN123456789"
  }'
```

### Step 3: Payment is Recorded
- ✅ Billing marked as paid
- ✅ Payment record created
- ✅ Linked to both Patient and Doctor

### Step 4: View Payment History

**Patient View:**
```bash
curl http://localhost:5000/api/billings/patient/1/payments
```

**Doctor View:**
```bash
curl http://localhost:5000/api/billings/doctor/1/payments
```

---

## Key Features

✅ **Dual-Entry System**: Every payment is visible to both patient and doctor
✅ **Payment Tracking**: Detailed payment records with method, timestamp, and notes
✅ **History**: Complete payment history for both parties
✅ **Earnings Reports**: Doctors can track total payments received
✅ **Audit Trail**: Transaction IDs for payment verification
✅ **Cascade Delete**: Payments deleted if billing is deleted

---

## Database Migration

### Migration Applied
- **Name**: `AddPaymentTracking`
- **Tables Created**: `Payments`
- **Columns Added**:
  - To Patient: Foreign key to Payments
  - To Doctor: Foreign key to Payments
  - To Billing: Payments collection

### Run Migration
```bash
dotnet ef database update
```

---

## Security & Authorization

All payment endpoints require authentication:
- **Roles Allowed**: `Admin`, `Doctor`, `Patient`
- **Authorization**: Users can only view their own payment records
  - Patients see only their payments
  - Doctors see only payments for their services

---

## Future Enhancements

Potential additions:
- Payment status tracking (Pending, Completed, Failed, Refunded)
- Payment installments/partial payments
- Reconciliation reports
- Payment gateway integration
- Automated payment reminders
- Payment analytics and dashboards

---

## Testing the Feature

### 1. Test Successful Payment
```bash
# Process payment
POST /api/billings/pay
{
  "billingId": 1,
  "amount": 500.00,
  "paymentMethod": "Cash"
}
```

### 2. Test Payment History
```bash
# Get patient payments
GET /api/billings/patient/1/payments

# Get doctor payments
GET /api/billings/doctor/1/payments
```

### 3. Verify Data
- Check Payment table in database
- Verify Patient.Payments collection populated
- Verify Doctor.Payments collection populated
- Confirm IsPaid and PaidAt on Billing updated

---

## Troubleshooting

### Issue: Payment not appearing in history
- Verify BillingId is correct
- Confirm PatientId and DoctorId are present in Appointment
- Check database Payment table directly

### Issue: Migration failed
- Run: `dotnet ef migrations remove` and re-apply
- Clear bin/obj folders and rebuild

### Issue: Authorization errors
- Ensure user has correct role (Admin/Doctor/Patient)
- Verify JWT token is valid and not expired
