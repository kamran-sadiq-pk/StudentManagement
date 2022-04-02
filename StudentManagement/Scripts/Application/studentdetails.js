let studentDetails = new Vue({
    el: '#studentDetails',
    data: {

        studentDetail: { StudentId: 0, FirstName: "", LastName: "", Email: "", CourseName: "", CourseId: 0, StatusId: 0, Status: "" },

    },
    mounted: function () {
        let self = this;
        let url = window.location.href;
        if (url.includes('?')) {
            var id = new URLSearchParams(window.location.search).get('id');
            this.GetStudentDetails(id);

        }


    },
    methods: {
        Verify: function (id, statusId) {
            debugger;
            let self = this;

            $.confirm({
                title: 'Action Require',
                content: 'Are you sure you want verify this student?',
                buttons: {
                    Yes: function () {
                        $.ajax({
                            url: '/CMS/ActiveInActiveStatusStudent?studentId=' + id + '&statusId=' + statusId,
                            type: 'GET',
                            async: false,
                            dataType: 'json',
                            success: function (data) {
                                if (data.Status) {
                                    $.notify(data.FeedBack, "success");

                                }
                            },
                            error: function (request, error) {
                            }
                        });
                    },
                    cancel: function () {

                    },

                }
            });


        },


        GetStudentDetails: function (id) {
            let self = this;
            $.ajax({
                url: '/CMS/GetStudentDetails?id=' + id,
                type: 'GET',
                async: false,
                dataType: 'json',
                success: function (data) {
                    debugger;
                    self.studentDetail = data;
                },
                error: function (request, error) {

                }
            });
        }
    }
})