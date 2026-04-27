// //10-dan 1-ə qədər ədədləri əks sırada çap et.
// for (let i = 10; i >= 1; i--) {
//     console.log(i);
// }





// //1-dən 20-ə qədər olan cüt ədədlərin cəmini tap.
// let sum = 0;
// for (let i = 1; i <= 20; i++) {
//     if (i % 2 === 0) {
//         sum += i;
//     }
// }
// console.log(sum);





// //1-dən 10-a qədər olan ədədlərin kvadratlarını çap et.
// for (let i = 1; i <= 10; i++) {
//     console.log(i * i);
// }




// //Bir mətn daxil et və for döngüsü ilə hər bir hərfini ayrı-ayrılıqda çap et.
// let soz = "Azerbaycan";
// for (let i = 0; i < soz.length; i++) {
//     console.log(soz[i]);
// }





// //1-dən 100-ə qədər olan ədədlərdən 5-ə və 7-yə bölünənləri tap və çap et.
// for(let i=1;i<100;i++){
//     if(i%5==0 && i%7==0){
//         console.log(i)
//     }
// }





// // Bir funksiya yazın.Bu funksiya 1 və 100 arasındakı sonu 9 ilə bitən ədədlərin sayını qaytarsın.
// function example(){
//     var say = 0;
//     for(let i = 1; i <= 100; i++){
//         if(i % 10 == 9){
//             say = say + 1;
//         }
//     }
//     return say;
// }
// console.log(example());





// //Bir funksiya yazın. Bu funksiya rəqəmləri eyni olan bütün ikirəqəmli ədədlərin sayını qaytarsın.
// function sayTap() {
//     let count = 0;

//     for (let i = 10; i <= 99; i++) {
//         if (i % 11 === 0) {
//             count++;
//         }
//     }
//     return count;
// }
// console.log(sayTap()); 





// //Bir funksiya yazın. Bu funksiya vurma cədvəlini ekrana çıxarsın.
// function vurmacedveli(){
//     for (let i = 1; i <= 10; i++) {
//         for (let j = 1; j <= 10; j++) {
//           console.log(i + " x " + j + " = " + (i * j));
//         }
//         console.log("-----------");
//       }
// }
// vurmacedveli()




// //Bir funksiya yazın. Bu funksiya ədəd şəklində bir parametr qəbul etsin  və həmin ədədin rəqəmlərinin cəmini qaytarsın.
// function ededcem(a){
//     let cem=0
//     while(a>0){
//         cem=a%10+cem
//         a = Math.floor(a / 10);
//     }return cem
// }
// console.log(ededcem(23))





// //Bir funksiya yazın. Bu funksiya ədəd şəklində bir parametr qəbul etsin  və həmin ədədin sadə olub-olmadığını tapsın.
// function sade(a){
//     let say=0
//     for(let i=1;i<=a;i++){
//         if(a%i==0){
//             say=say+1
//         }
//     }if(say==2){
//         console.log("sadedir")
//     }
//     else{
//         console.log("sade deil")
//     }
// }
// sade(7)





// //• Bir funksiya yazın.Bu funksiya ədəd şəklində bir parametr qəbul etsin və həmin ədədin mürıkkəb ədəd olub-olmadığını qaytarsın.Əgər natural ədədin özü bölənlərinin (özündən başqa) cəminə bərabərdirsə, ona mükəmməl ədəd deyilir.
// function mukemmel(a){
//     let say=0
//     let cem=0
//     for(let i=1;i<=a;i++){
//         if(a%i==0){
//             say=say+1
//             cem=cem+i
//         }
//     }if(say==2){
//         console.log("sadedir")
//     }
//     else if (say>2){
//         console.log("sade deil")
//     }
//     cem=cem-a
//     if(cem==a){
//         console.log("eded mukemmeldi")
//     }
//     else{
//         console.log("mukemmel deil")
//     }
// }
// mukemmel(6)





// //Bir funksiya yazın.Bu funksiya rəqəmlərdən ibarət array qəbul etsin və həmin arraydə  tək elementlərin indeksini ekrana çıxarsın
// function tekindeks(arr) {
//     for (let i = 0; i < arr.length; i++) {
//         if (arr[i] % 2 !== 0) {
//             console.log(i)
//         }
//     }
// }
// tekindeks([10, 3, 7, 8, 5])





// //Bir funksiya yazın.Bu funksiya rəqəmlərdən ibarət array qəbul etsin və həmin arraydə  cüt elementlərin indeksini ekrana çıxarsın.
// function cutindeks(arr) {
//     for (let i = 0; i < arr.length; i++) {
//         if (arr[i] % 2 === 0) {
//             console.log(i);
//         }
//     }
// }
// cutindeks([10, 3, 7, 8, 5, 12]);





// //Bir fuksiya yazın. Bu funksiya rəqəmlərdən ibarət bir arrayi parametr kimi qəbul etsin və daxil edilən arraydə ədədlərin ədədi ortasını tapsın.Sonda nəticəni tam ədədə yuvarlaqlaşdırın
// function edediorta(arr) {
//     let sum = 0;
//     for (let i = 0; i < arr.length; i++) {
//         sum += arr[i];
//     }
//     let avg = sum / arr.length;
//     return Math.round(avg);
// }
// console.log(edediorta([10, 20, 30]))





//yazammadim
// //Bir funksiya yazın. Parametr olaraq bir ədəd qəbul etsin. Eger bu ədəd 7-ye bölünürsə ekrana "7 yə bölünür" yazılsın. Əks halda daxil olunan ədədə ən yaxın 7-yə blunen eded ekranda yazilsin(Meselen: 17 yazilibsa ekrana  21 yox 14 cixsin, 19 yazilibsa 21 cixsin)
// function bolme(a){
//     if(a%7==0){
//     console.log("7 e bolunur")
//     }
//     else{
         
//     }
// }
// bolme(24)





// //Bir funksiya yazın. Bir ədədi parametr olaraq qəbul edir. Eger o eded 50den kicikdirse o edede qeder 3-e bolunen, 50-100 araligindadirsa o edede qeder 5e bolunen, 100den boyukdurse o edede qeder 8 e bolunen ededlerin sayini ekrana cixardan bir alqoritm yazin.
// function say(n) {
//     let bolen;
//     let saygac = 0;
//     if (n < 50) {
//         bolen = 3;
//     } else if (n <= 100) {
//         bolen = 5;
//     } else {
//         bolen = 8;
//     }
//     for (let i = 1; i <= n; i++) {
//         if (i % bolen === 0) {
//             saygac++;
//         }
//     }
//     console.log(saygac);
// }
// say(20);
// say(75);
// say(120);





// //Bir function yazin bir reqem parametri Qebul edir ve hemin reqeme uygun olan ayin adini qaytarir, meselen 5 daxil olunsa function "May" return etmelidir, eger 12-den boyuk ve ya menfi olan bir deyer daxil olunsa invalid input return etmelidir
// function ayadlar(n) {
//     switch (n) {
//         case 1:
//             return "Yanvar";
//         case 2:
//             return "Fevral";
//         case 3:
//             return "Mart";
//         case 4:
//             return "Aprel";
//         case 5:
//             return "May";
//         case 6:
//             return "İyun";
//         case 7:
//             return "İyul";
//         case 8:
//             return "Avqust";
//         case 9:
//             return "Sentyabr";
//         case 10:
//             return "Oktyabr";
//         case 11:
//             return "Noyabr";
//         case 12:
//             return "Dekabr";
//         default:
//             return "invalid input";
//     }
// }
// console.log(ayadlar(5)); 
// console.log(ayadlar(-2));







// //Bir function yazin, function bir herf ve bir reqem qebul edir ve gonderilen reqem qeder hemin herfi yazib return edir, meselen function-a arqument olaraq 3 ve b gonderilerse output bbb olmalidir.
// function tekrar(herf, number) {
//     let result = "";
//     for (let i = 0; i < number; i++) {
//         result += herf;
//     }

//     return result;
// }
// console.log(tekrar("b", 3))






// //Bir funksiya yazın. Bir  string parametr  qəbul etsin. Funksiyanınız həmin sözün bütün hərflərini böyük edib geri qaytarsın.
// function boyukherf(str) {
//     return str.toUpperCase();
// }
// console.log(boyukherf("salam"))










