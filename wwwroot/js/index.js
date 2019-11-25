var express = requre('express');
var app = express();

app.use(express.static('public'));

const navSlide = () => {
    const burger = document.querySelector('.burger');
    const mobileNav = document.querySelector('.mobileNav');

    burger.addEventListener('click', ()=>{
        mobileNav.classList.toggle('burger-active')
    });
}

navSlide();