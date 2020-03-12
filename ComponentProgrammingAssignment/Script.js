var canvas = document.querySelector('canvas');
var flipBox = document.querySelector('.flipCard');
var flipInnerBox = document.querySelector('.flipCardInner');

document.getElementById('animateButton').onclick = animate;

document.getElementById('flipButton').onclick = flipTheCard;

console.log(flipBox);
console.log(canvas);

canvas.width = window.innerWidth;
canvas.height = window.innerHeight;

var c = canvas.getContext('2d');

var colourArray = [
    '#FED0D0',
    '#D1C8E8',
    '#D8FBFC',
    '#CAE6BA',
    '#FEF0CE',
];

function Circle(x, y, radius, dx, dy) {
    this.x = x;
    this.y = y;
    this.radius = radius;
    this.dx = dx;
    this.dy = dy;
    this.colour = colourArray[Math.floor(Math.random() * colourArray.length)];

    this.draw = function () {
        c.beginPath();
        c.arc(this.x, this.y, this.radius, 0, Math.PI * 2, false);
        c.strokeStyle = this.colour;
        c.stroke();
        c.fillStyle = this.colour;
        c.fill();
    }

    this.update = function () {
        if (this.x + this.radius > innerWidth || this.x - this.radius < 0) {
            this.dx = -this.dx;
        }
        if (this.y + this.radius > innerHeight || this.y - this.radius < 0) {
            this.dy = -this.dy;
        }
        this.x += this.dx;
        this.y += this.dy;

        this.draw();
    }
}

function getRandom(min, max) {
    return Math.random() * (max - min) + min;
}

var circles = [];

for (var i = 0; i < 20; i++) {

    var radius = getRandom(10, 60);
    var x = Math.random() * (innerWidth - (radius * 2)) + radius;
    var y = Math.random() * (innerHeight - (radius * 2)) + radius;
    var dx = (Math.random() - 0.5) * 10;
    var dy = (Math.random() - 0.5) * 10;

    circles.push(new Circle(x, y, radius, dx, dy));
}

function animate() {
    requestAnimationFrame(animate);

    c.clearRect(0, 0, innerWidth, innerHeight);

    for (var i = 0; i < circles.length; i++) {
        circles[i].update();
    }
}

function flipTheCard() {
    let xPos = 0;
    let yPos = 180;
    flipBox.style.transform = 'rotateY(180deg)';
    flipInnerBox.style.transform = 'rotateY(180deg)';
}
