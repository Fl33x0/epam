let s = "1+2/3*2.255=";

function Calculator(mathExpressionString) {
    mathExpressionString = SpaceRemover(mathExpressionString);    

    let _expressionMembers = GetExpressionMembers(mathExpressionString);

    let _regex = /([+\/\-*]?\d{1,}(\.\d{1,})?){1,}=/g;
    let _expressionFormatCheck = _regex.test(mathExpressionString);

    if (!_expressionFormatCheck) {
        throw new Error('The input string was wrong');
    }

    let _result = Number.parseFloat(_expressionMembers[0]);
    let _memberChars;

    let _numberInMember;
    for (let i = 1; i < _expressionMembers.length; i++) {
        _memberChars = _expressionMembers[i].split("");
        
        _numberInMember = Number.parseFloat(_memberChars.slice(1, _memberChars.length).join(""));
        switch (_memberChars[0]) {
            case "+":
                _result += _numberInMember;
                break;
            case "-":
                _result -= _numberInMember;
                break;
            case "*":
                _result *= _numberInMember;
                break;
            case "/":
                _result /= _numberInMember;
                break;
        
            default:
                break;
        }
    }

    return _result.toFixed(2);
}

function SpaceRemover(someString) {

    let _inputCharArr = someString.split("");

    for (let i = 0; i < _inputCharArr.length; i++) {
        if (_inputCharArr[i] == " ") {
            _inputCharArr.splice(i, 1);
        }
    }

    return _inputCharArr.join("");
}

function GetExpressionMembers(someString) {

    let _regex = /[+\/\-*]?\d{1,}(\.\d{1,})?/g;
    
    return someString.match(_regex);
}