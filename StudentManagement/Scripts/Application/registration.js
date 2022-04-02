
let student_registration = new Vue({
    el: '#student_registration',
    data: {
        student: { FirstName: "", LastName: "", Email: "", Password: "", CourseId: 0 },
        courses: [],

    },
    mounted: function () {
        this.GetCourses();

    },
    methods: {
        SaveStudent: function () {
            let self = this;
            self.student.CourseId = this.$refs.selectedCourse.value;
            $.ajax({

                url: '/Account/Registration/',
                type: 'POST',
                async: false,
                dataType: 'json',
                data: { student: self.student },
                success: function (data) {
                    debugger;
                    if (data.Status) {
                        alert(data.FeedBack);
                    }

                },
                error: function (request, error) {

                }
            });
        },
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
    }

})
