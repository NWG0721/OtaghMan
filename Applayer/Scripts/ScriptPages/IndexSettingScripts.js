let eyeSymbol = document.getElementById("EyeSymbol");
let userPassWord = document.getElementById("UserPassWord");
let eyeStatus = false;
function EyeSymbolControleStartUp() {
  eyeSymbol.src = "./Sources/Pictures/icons8-view-48.png";
  setTimeout(() => {
    eyeSymbol.src = "./Sources/Pictures/icons8-hide-48.png";
  }, 2000);
  setTimeout(() => {
    eyeSymbol.src = "./Sources/Pictures/icons8-view-48.png";
  }, 2100);
  setTimeout(() => {
    eyeSymbol.src = "./Sources/Pictures/icons8-hide-48.png";
  }, 3200);
  setTimeout(() => {
    eyeSymbol.src = "./Sources/Pictures/icons8-view-48.png";
  }, 3300);
}
function EyeSymbolControleOnClick() {
  if (eyeStatus) {
    eyeSymbol.src = "./Sources/Pictures/icons8-view-48.png";
    userPassWord.type = "password";
} else {
    eyeSymbol.src = "./Sources/Pictures/icons8-hide-48.png";
    userPassWord.type = "text";
  }
  eyeStatus = !eyeStatus;
}
