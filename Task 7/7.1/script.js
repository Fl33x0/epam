let s = "Мама мыла раму. А папа...";

function CharRemover(someString)
{   
    let _strCharArr = String(someString).split("");
    let _words = [];
    let _separators = [".", ",", "!", "?", " ", "    "];
    let n = 0;

    for (let i = 0; i < _strCharArr.length; i++) {
        if (_strCharArr.slice(n, i) != "" & i == (_strCharArr.length - 1)) {
            _words.push(_strCharArr.slice(n, i + 1).join(""));
        }
        else {
            if (_separators.includes(_strCharArr[i])) {

                if (_strCharArr.slice(n, i) != "") {
                    _words.push(_strCharArr.slice(n, i).join(""));
                }

                n = i + 1;
            }
        }
    }

    let _wordChars = [];
    let _repeatInd;

    let _doubles = [];

    for (let i = 0; i < _words.length; i++) {
        _wordChars = _words[i].split("");
        for (let j = 0; j < _wordChars.length; j++) {
        
            _repeatInd = 0;
    
            for (let k = 0; k < _wordChars.length; k++) {
               
                if (_wordChars[j] == _wordChars[k] & !_separators.includes(_wordChars[k])) {                
                   _repeatInd++;
                }            
            } 
    
            if (_repeatInd > 1 & !_doubles.includes(_wordChars[j])) {
                _doubles.push(_wordChars[j]);
            }               
        }        
    }    
    
    let _result = [];

    for (let i = 0; i < _strCharArr.length; i++) {
        if (!_doubles.includes(_strCharArr[i])) {
            _result.push(_strCharArr[i]);
        }        
    }

    return _result.join("");
}