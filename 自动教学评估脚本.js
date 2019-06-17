(function(){
    counter = 0;
    selects = $('iframeautoheight').contentDocument.getElementsByTagName('select');
    courseNum = selects[0].length;
    let autoOption = function(){
        //每一次需要重新获取当前表单的select数目
        selects = $('iframeautoheight').contentDocument.getElementsByTagName('select');
        //跳过表单中第一个select
        for(let i=1;i<selects.length;i++){
            //默认循环的选取每个select里面的options[1]            
            selects[i].options[1].selected = true;
        }
        // 随机选中一个修改为其他值
        let changeIndex=Math.max(1, Math.floor(Math.random()*selects.length));
        selects[changeIndex].options[1].selected = false;
        selects[changeIndex].options[2].selected = true;
        //模拟点击保存 button
        $('iframeautoheight').contentDocument.getElementById('Button1').click();
        counter++;
    }
    //trigger
    autoOption();
    //监测到iframe onload事件触发就开始自动填写
    $('iframeautoheight').onload = function(){
        if(counter < courseNum){
            autoOption();
        }else{
            // 一旦填写完成就点击 提交button
            $('iframeautoheight').contentDocument.getElementById('Button2').click();
            console.log('FINISHED！！！！');
        }
    }
})()