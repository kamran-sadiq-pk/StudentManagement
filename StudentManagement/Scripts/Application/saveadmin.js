let addAdmin = new Vue({
    el: '#addAdmin',
    data: {
        admin: { AdminId: 0, FirstName: "", LastName: "", Email: "", Status: -1 },
        statuses: []

    },

    mounted: function () {
        this.GetStatus();
        let url = window.location.href;
        if (url.includes('?')) {
            var id = new URLSearchParams(window.location.search).get('id');
            this.GetAdminbyId(id)
        }
    },
    methods: {
        SaveAdmin: function () {
            let self = this;
            self.admin.Status = this.$refs.selectedStatus.value;
            $.ajax({

                url: '/CMS/SaveAdmin/',
                type: 'POST',
                async: false,
                dataType: 'json',
                data: { admin: self.admin },
                success: function (data) {

                    if (data.Status) {
                        $.notify(data.FeedBack, "success");

                    }

                },
                error: function (request, error) {

                }
            });
        },

        GetStatus: function () {
            let self = this;
            $.ajax({

                url: '/Common/GetStatus',
                type: 'GET',
                async: false,
                dataType: 'json',
                success: function (data) {

                    self.statuses = data;

                },
                error: function (request, error) {

                }
            });
        },
        GetAdminbyId: function (id) {
            let self = this;
            $.ajax({

                url: '/CMS/GetAdminById?id=' + id,
                type: 'GET',
                async: false,
                dataType: 'json',
                success: function (data) {
                    debugger;
                    self.admin = data[0];


                },
                error: function (request, error) {

                }
            });
        },
    }

})