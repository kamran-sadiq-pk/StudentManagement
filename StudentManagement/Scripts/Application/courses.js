let courses = new Vue({
    el: '#courses',
    data: {

        courses: []

    },
    mounted: function () {
        this.GetCourses();

    },
    methods: {

        GetCourses: function () {
            let self = this;
            $.ajax({

                url: '/Common/GetCourses/',
                type: 'GET',
                async: false,
                dataType: 'json',
                success: function (data) {
                    debugger;
                    self.courses = data;

                },
                error: function (request, error) {

                }
            });
        },

        Delete: function (id) {
            let self = this;
            $.confirm({
                title: 'Action Require',
                content: 'Are you sure you want to delete this course?',
                buttons: {
                    Yes: function () {
                        $.ajax({
                            url: '/CMS/DeleteCourseById?id=' + id,
                            type: 'GET',
                            async: false,
                            dataType: 'json',
                            success: function (data) {
                                $.notify(data.FeedBack, "success")
                                self.GetCourses();
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