(function(){
    counter = 0;
    selects = $('iframeautoheight').contentDocument.getElementsByTagName('select');
    courseNum = selects[0].length;
    let autoOption = function(){
        //ÿһ����Ҫ���»�ȡ��ǰ����select��Ŀ
        selects = $('iframeautoheight').contentDocument.getElementsByTagName('select');
        //�������е�һ��select
        for(let i=1;i<selects.length;i++){
            //Ĭ��ѭ����ѡȡÿ��select�����options[1]            
            selects[i].options[1].selected = true;
        }
        // ���ѡ��һ���޸�Ϊ����ֵ
        let changeIndex=Math.max(1, Math.floor(Math.random()*selects.length));
        selects[changeIndex].options[1].selected = false;
        selects[changeIndex].options[2].selected = true;
        //ģ�������� button
        $('iframeautoheight').contentDocument.getElementById('Button1').click();
        counter++;
    }
    //trigger
    autoOption();
    //��⵽iframe onload�¼������Ϳ�ʼ�Զ���д
    $('iframeautoheight').onload = function(){
        if(counter < courseNum){
            autoOption();
        }else{
            // һ����д��ɾ͵�� �ύbutton
            $('iframeautoheight').contentDocument.getElementById('Button2').click();
            console.log('FINISHED��������');
        }
    }
})()