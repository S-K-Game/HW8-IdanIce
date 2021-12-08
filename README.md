

<div dir="rtl" lang="he">

# HW8-IdanIce
במשחק זה השחקן נמצא באנטרקטיקה ועליו לחפור בשלג באזורים המותרים לו ולחפש אחר האקדח על מנת להרוג את האויב שלו. 
ניתן לראות כי בתחילת המשחק ישנם מסכי הסבר על רקע השחקן ועל העלילה של המשחק.
![](https://github.com/S-K-Game/HW8-IdanIce/blob/main/images/%D7%9E%D7%A1%D7%9A1.png)

![](https://github.com/S-K-Game/HW8-IdanIce/blob/main/images/%D7%9E%D7%A1%D7%9A2.png)

![](https://github.com/S-K-Game/HW8-IdanIce/blob/main/images/%D7%9E%D7%A1%D7%9A3.png)

![](https://github.com/S-K-Game/HW8-IdanIce/blob/main/images/%D7%9E%D7%A1%D7%9A%20%D7%97%D7%95%D7%A7%D7%99%D7%9D.png)

כמו כן, ישנם מספר סקריפטים עיקריים:
1. [תזוזת השחקן-](https://github.com/S-K-Game/HW8-IdanIce/blob/main/Scripts/CharacterKeyboardMover.cs) סקריפט זה שולט על תזוזת השחקן עם החיצים , בנוסף כאשר מתבצעת הליכה או תזוזה הוא מפעיל את האנימציה כך שתדע לחפור/ ללכת.
2. [הריסת השלג-](https://github.com/S-K-Game/HW8-IdanIce/blob/main/Scripts/destroySnow.cs) מטרת הסקריפט יא להרוס את השלג ברגע שהשחקן נוגע בו על מנת לדמות חפירה בשלג. 
ניתן לראות כי השתמשנו בקוליידרים.
3. [splash](https://github.com/S-K-Game/HW8-IdanIce/blob/main/Scripts/toSplash.cs)- מטרת סקריפט זה היא כעבור מספר שניות המוגדרות להחליף לבד את הסצנה כך שהשחקן יוכל לראות את הפתיח ברצף. 
4. תזוזת המצלמה סביב ציר ה[X](https://github.com/S-K-Game/HW8-IdanIce/blob/main/Scripts/LookY.cs) וה[Y](https://github.com/S-K-Game/HW8-IdanIce/blob/main/Scripts/LookX.cs)

</div>
