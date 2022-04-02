let admins = new Vue({
    el: '#admins',
    data: {

        admins: []

    },
    mounted: function () {
        this.GetAdmins();

    },
    methods: {
        GetAdmins: function () {
            let self = this;
            $.ajax({
                url: '/Common/GetAdmins/',
                type: 'GET',
                async: false,
                dataType: 'json',
                success: function (data) {
                    self.admins = data;
                },
                error: function (request, error) { }
            });
        },

        Delete: function (id) {
            let self = this;
            $.confirm({
                title: 'Action Require',
                content: 'Are you sure you want to delete this admin?',
                buttons: {
                    Yes: function () {
                        $.ajax({
                            url: '/CMS/DeleteAdminById?id=' + id,
                            type: 'GET',
                            async: false,
                            dataType: 'json',
                            success: function (data) {
                                $.notify(data.FeedBack, "success")
                                self.GetAdmins();
                            },
                            error: function (request, error) { }
                        });
                    },
                    cancel: function () {

                    },

                }
            });
        }
    }

})