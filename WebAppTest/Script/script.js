window.onload=function(){
    var textBox = document.querySelector('#TextBox3');
    var textBox4 = document.querySelector('#TextBox4');
    var textBox6 = document.querySelector('#TextBox6');
    var valid = document.querySelector('#Button1');
    var valid2 = document.querySelector('#Button2');
    var drop = document.querySelector('#DropDownList1');
    var label1 = document.querySelector('#Label1');
    var label2 = document.querySelector('#Label2');
    var label3 = document.querySelector('#Label3');

  
    }
    valid2.onclick=function() {
        if(textBox6.text!="")
        { label3.innerText = "Выберите дату" } else {
            label3.innerText = "";
        }
    }





    textBox4.onmouseup = function () {
        if (textBox4.value != "") {
            label2.innerText = "Выберите дату"
        } else label2.innerText = "";
    }
    valid.onclick = function() {
        if (textBox.value == "") {
            alert('Вы не ввели колличество  деталей');}
        if (drop.value != "Выберите кладовщика")
        {//label1.innerText = "";
        }
        else { label1.innerHTML = "Выберите кладовщика"; }
        if (textBox4.value != "")
            label2.innerText = "";

    };
    drop.onclick = function() {
        if (drop.value != "Выберите кладовщика")
        { label1.innerText = "";}
    };

};


