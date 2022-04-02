let saveCourse = new Vue({
    el: '#saveCourse',
    data: {
        course: { CourseId: 0, CourseName: "", CreditHours: "", Author: "", Status: -1 },
        statuses: []
    },

    mounted: function () {
        this.GetStatus();
        let url = window.location.href;
        if (url.includes('?')) {
            var id = new URLSearchParams(window.location.search).get('id');
            this.GetCourseById(id)
        }
    },
    methods: {
        SaveCourse: function () {
            let self = this;
            self.course.Status = this.$refs.selectedStatus.value;
            $.ajax({

                url: '/CMS/SaveCourse/',
                type: 'POST',
                async: false,
                dataType: 'json',
                data: { courseViewModel: self.course },
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

                url: '/Common/GetStatus/',
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
        GetCourseById: function (id) {
            let self = this;
            $.ajax({

                url: '/CMS/GetCourseById/?id=' + id,
                type: 'GET',
                async: false,
                dataType: 'json',
                success: function (data) {
                    self.course = data;
                },
                error: function (request, error) {

                }
            });
        },


    }

})