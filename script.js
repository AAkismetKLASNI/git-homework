const inputImg = document.querySelector('.inputImg');
const outputImg = document.querySelector('.outputImg');

inputImg.addEventListener('change', () => {
    outputImg.src = URL.createObjectURL(inputImg.files[0]);
    outputImg.style.display = "block";
})