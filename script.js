const countAppleInKg = document.querySelector('.countAppleInKg');
const resultPrice = document.querySelector('.resultPrice');
const oneKgPrice = document.querySelector('.oneKgPrice');

const priceOneKgApple = 121;

oneKgPrice.innerHTML = `(цена одного КГ: ${priceOneKgApple})`;

countAppleInKg.addEventListener('change', () => {
    const result = (countAppleInKg.value * priceOneKgApple);

    resultPrice.innerHTML = `${result} р`;
})
