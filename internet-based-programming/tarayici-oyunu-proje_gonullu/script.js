var score = 0;
var timeLeft = 30;
var gameTimer = null;

var scoreText = document.getElementById("score");
var timeText = document.getElementById("time");
var message = document.getElementById("message");
var target = document.getElementById("target");
var gameArea = document.getElementById("gameArea");
var startBtn = document.getElementById("startBtn");
var resetBtn = document.getElementById("resetBtn");

startBtn.onclick = function () {
  score = 0;
  timeLeft = 30;
  scoreText.innerHTML = score;
  timeText.innerHTML = timeLeft;
  message.innerHTML = "Oyun başladı. Kod sembolünü yakala!";
  target.disabled = false;
  startBtn.disabled = true;
  moveTarget();

  gameTimer = setInterval(function () {
    timeLeft = timeLeft - 1;
    timeText.innerHTML = timeLeft;

    if (timeLeft <= 0) {
      clearInterval(gameTimer);
      target.disabled = true;
      startBtn.disabled = false;
      message.innerHTML = "Oyun bitti. Toplam puanın: " + score;
    }
  }, 1000);
};

target.onclick = function () {
  score = score + 1;
  scoreText.innerHTML = score;
  moveTarget();
};

resetBtn.onclick = function () {
  clearInterval(gameTimer);
  score = 0;
  timeLeft = 30;
  scoreText.innerHTML = score;
  timeText.innerHTML = timeLeft;
  target.disabled = true;
  startBtn.disabled = false;
  message.innerHTML = "Oyun sıfırlandı. Başlamak için butona tıkla.";
  target.style.left = "40%";
  target.style.top = "40%";
};

function moveTarget() {
  var maxLeft = gameArea.clientWidth - target.clientWidth;
  var maxTop = gameArea.clientHeight - target.clientHeight;
  var randomLeft = Math.floor(Math.random() * maxLeft);
  var randomTop = Math.floor(Math.random() * maxTop);

  target.style.left = randomLeft + "px";
  target.style.top = randomTop + "px";
}
