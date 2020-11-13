$(document).ready(function () {

    var app = new Vue({
        el: '#app',
        data: {
            reviews: [],
            review: {
                title: "",
                content: "",
                time: ""
            }
        },

        async created() {
            let res = await axios.get('/api/review');
            this.reviews = res.data;
        },

        methods: {
            addReview: function () {
                var self = this;

                axios.post('/api/review', self.review).then(function (response) {
                    self.products.push(response.data);
                });
            },
        }
    });
});