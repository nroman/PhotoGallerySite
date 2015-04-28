(function () {
    var windowParent = window;
    if (window.location.search.match("[?&]IsDlg=1")) {
        windowParent = self.parent.window;
    }

    if (typeof windowParent.photoGalleryClientHelper === "undefined") {
        windowParent.photoGalleryClientHelper = {};
    }

    windowParent.photoGalleryClientHelper =
    {
        showActiveMenuItem: function (pageAbsPath) {
            $(".menu a").each(function () {                
                if ($(this).attr('href') === pageAbsPath) {
                    $(this).addClass("activeLink");
                }
            });
        },

        onSubmitClick: function () {
            $('form').validate({
                rules: {
                    userEmail: {
                        email: true, //TODO: add more stronger validation than this
                        required: true,
                        maxlength: 100
                    },
                    fullName: {
                        required: true,
                        minlength: 2,
                        maxlength: 100
                    },
                    title: {
                        required: true,
                        minlength: 5,
                        maxlength: 100
                    },
                    messageArea: {
                        required: true,
                        minlength: 50,
                        maxlength: 500
                    }
                },

                errorClass: "invalidValue"
            });

            if ($('form').valid()) {
                //TODO: add here ajax call back for sending the data from client to the server
                window.alert('valid!');
            }
        }
    };
}());