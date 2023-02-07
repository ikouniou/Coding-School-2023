function endsWithNumber(str) {

    if(/[0-9]+$/.test(str)){
        let num = Number(str.match(/[0-9]+$/)) + 1;
        let word = String(str.match(/[A-Za-z]+/g));
        let newstr = word+num;
        return newstr;
    }
    else{
        let newstr = str + "1";
        return newstr;
    }
  }
  
  
//case1
//   console.log(endsWithNumber("Ioanna59"));
//   console.log(endsWithNumber("Foo22"));
//   console.log(endsWithNumber("Hello4"));

 //case2
//   console.log(endsWithNumber("Ioanna"));
//   console.log(endsWithNumber("Foo"));
//   console.log(endsWithNumber("Hello"));
  
 