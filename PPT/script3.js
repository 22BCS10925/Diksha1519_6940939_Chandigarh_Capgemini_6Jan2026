const questions = [
    {
        question: "Which language is used for web styling?",
        options: ["HTML", "CSS", "Python", "C#"],
        answer: "CSS"
    },
    {
        question: "Which keyword declares a variable in JS?",
        options: ["int", "var", "define", "dim"],
        answer: "var"
    }
];

let currentQuestion = 0;
let score = 0;
let timeLeft = 10;
let timerInterval;

const questionEl = document.getElementById("question");
const optionsEl = document.getElementById("options");
const nextBtn = document.getElementById("nextBtn");
const timerEl = document.getElementById("timer");

function startTimer() {
    timeLeft = 10;
    timerEl.textContent = `Time Left: ${timeLeft}s`;

    timerInterval = setInterval(() => {
        timeLeft--;
        timerEl.textContent = `Time Left: ${timeLeft}s`;

        if (timeLeft === 0) {
            clearInterval(timerInterval);
            nextBtn.disabled = false;
        }
    }, 1000);
}

function loadQuestion() {
    nextBtn.disabled = true;
    optionsEl.innerHTML = "";

    const q = questions[currentQuestion];
    questionEl.textContent = q.question;

    q.options.forEach(option => {
        const btn = document.createElement("button");
        btn.textContent = option;

        btn.onclick = () => {
            clearInterval(timerInterval);

            if (option === q.answer) {
                btn.classList.add("correct");
                score++;
            } else {
                btn.classList.add("wrong");
            }

            Array.from(optionsEl.children).forEach(b => b.disabled = true);
            nextBtn.disabled = false;
        };

        optionsEl.appendChild(btn);
    });

    startTimer();
}

nextBtn.onclick = () => {
    currentQuestion++;
    if (currentQuestion < questions.length) {
        loadQuestion();
    } else {
        document.querySelector(".quiz-container").innerHTML =
            `<h2>Quiz Finished!</h2>
             <p>Your Score: ${score}/${questions.length}</p>`;
    }
};

loadQuestion();