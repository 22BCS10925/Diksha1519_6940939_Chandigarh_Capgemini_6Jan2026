# Payment Tracking API - Quick Reference

## New/Updated Endpoints

### 1. Process Patient Payment 
**Endpoint**: `POST /api/billings/pay`

When a patient pays a bill, this endpoint:
- ✅ Marks the billing record as paid
- ✅ Creates a Payment record for both patient and doctor
- ✅ Records payment method and timestamp
- ✅ Enables payment tracking for both parties

**Request**:
```json
{
  "billingId": 1,
  "amount": 500.00,
  "paymentMethod": "Cash",
  "notes": "Optional notes",
  "transactionId": "Optional ID"
}
```

---

### 2. Get Patient Payment History
**Endpoint**: `GET /api/billings/patient/{patientId}/payments`

Retrieve all payments made by a specific patient.

**Response**:
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
      "paidAt": "2026-04-06T10:30:45Z"
    }
  ]
}
```

---

### 3. Get Doctor Payment History
**Endpoint**: `GET /api/billings/doctor/{doctorId}/payments`

Retrieve all payments received by a specific doctor.

**Response**:
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
      "paidAt": "2026-04-05T09:15:30Z"
    }
  ]
}
```

---

## Key Implementation Details

### Payment Flow
```
Patient Pays → Payment Record Created → Linked to Patient & Doctor
                                   ↓
                Patient View → Doctor View
```

### Database Schema
```
Payments Table:
- Id (PK)
- BillingId (FK → Billings)
- PatientId (FK → Patients)
- DoctorId (FK → Doctors)
- Amount (decimal 18,2)
- PaymentMethod (varchar 50)
- Notes (varchar 500)
- TransactionId (varchar 100)
- PaidAt (DateTime)
```

### Model Updates
- **Patient.Payments**: Collection<Payment>
- **Doctor.Payments**: Collection<Payment>
- **Billing.Payments**: Collection<Payment>

---

## Complete Payment Workflow

```
1. Bill Created
   ↓
2. Patient Initiates Payment
   ↓
3. POST /api/billings/pay
   ├─ Update Billing (IsPaid=true)
   └─ Create Payment Record
   ↓
4. Payment appears in:
   - GET /api/billings/patient/X/payments
   - GET /api/billings/doctor/Y/payments
   ↓
5. Both parties can view payment history
```

---

## Authorization
All endpoints require authentication with roles: **Admin**, **Doctor**, or **Patient**

---

## Testing with cURL

### Process Payment
```bash
curl -X POST http://localhost:5000/api/billings/pay \
  -H "Content-Type: application/json" \
  -H "Authorization: Bearer {token}" \
  -d '{
    "billingId": 1,
    "amount": 500.00,
    "paymentMethod": "Cash",
    "transactionId": "TXN123456789"
  }'
```

### Get Patient Payments
```bash
curl http://localhost:5000/api/billings/patient/1/payments \
  -H "Authorization: Bearer {token}"
```

### Get Doctor Payments
```bash
curl http://localhost:5000/api/billings/doctor/1/payments \
  -H "Authorization: Bearer {token}"
```

---

## Status: ✅ IMPLEMENTED & DEPLOYED

- ✅ Payment model created
- ✅ Database migration applied
- ✅ Patient payment tracking enabled
- ✅ Doctor payment tracking enabled
- ✅ API endpoints implemented
- ✅ Servers running with new code
- ✅ Payment history retrieval working

