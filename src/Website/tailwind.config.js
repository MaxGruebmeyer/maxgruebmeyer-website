/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
       './Pages/**/*.cshtml',
       './Views/**/*.cshtml'
],
    theme: {
        extend: {
            aspectRatio: {
                '4/3': '4 / 3',
                '16/9': '16 / 9',
            }
        }
    },
    plugins: [
    ],
}
