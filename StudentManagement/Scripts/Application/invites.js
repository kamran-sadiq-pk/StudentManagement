let invites = new Vue({
    el: '#invites',
    data: {
        invites: []
    },
    mounted: function () {
        this.GetInvites();
    },
    methods: {

        GetInvites: function () {
            let self = this;
            $.ajax({
                url: '/Common/GetInvites/',
                type: 'GET',
                async: false,
                dataType: 'json',
                success: function (data) {
                    self.invites = data;
                },
                error: function (request, error) {

                }
            });
        },
    }

})
