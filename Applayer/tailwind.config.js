/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./../**/*.{html,js}"],
  theme: {
    extend: {
      colors: {
        "BackgroundColorBack": "#EEA5A6",
        "BackgroundColorFront": "#E493B3",
        "ForgroundColorBack": "#B784B7",
        "ForgroundColorFront": "#8E7AB5",
        "FontColor-zero": "#9A031E",
        "FontColor-one": "#E36414",
        "FontColor-two": "#FB8B24",
        "FontColor-three": "#5F0F40",
      },
    },
  },
  plugins: [require("@tailwindcss/forms")],
};
