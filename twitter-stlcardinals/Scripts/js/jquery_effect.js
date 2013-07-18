// jquery_effect.js

$(document).ready(function () {

    // Highlight hashtag On load
    hashTagHighlight();


    // Makes javascript work inside the UpdatePanel
    var prm = Sys.WebForms.PageRequestManager.getInstance();
    prm.add_beginRequest(BeginRequestHandler);
    prm.add_endRequest(EndRequestHandler);

    function BeginRequestHandler(sender, args) {
               
        // hashTagHighlight();
    }

    function EndRequestHandler(sender, args) {
        hashTagHighlight();
                
    }

    // Highlight Text
    function hashTagHighlight(textToHighLight) {
        // Grab each html element containing 'twitterItemText' class
        $('.twitterItemText').each(function () {
            // Grab text from twitter result
            str = $(this).html();

            // Wrap hashtag text with span tag for highlight effect
            newString = str.replace(/#STLCardinals/gi, '<span class="hashTagHighlight">#STLCardinals</span>');
        
            // Insert modified into element containing 'twitterItemText' class
            $(this).html(newString);
        })

    }
});