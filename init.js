window.htmx = require('htmx.org');
window._hyperscript = require('hyperscript.org');
window._hyperscript.browserInit();

// Ugly hack to not get anchor link clicks caught by Blazor script
window.anchorLink = {
    scrollIntoView: function (elementId) {
        var elem = document.getElementById(elementId);
        if (elem) {
            elem.focus({ focusVisible: true });
            window.history.pushState(null, "", window.location.pathname + "#" + elementId);
        }
    }
}