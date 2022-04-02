let students = new Vue({
    el: '#students',
    data: {
        students: []
    },
    mounted: function () {
        this.GetStudents();
    },
    methods: {
        GetStudents: function () {
            let self = this;
            $.ajax({
                url: '/Common/GetStudents/',
                type: 'GET',
                async: false,
                dataType: 'json',
                success: function (data) {
                    self.students = data;
                },
                error: function (request, error) {

                }
            });
        },

    }

})