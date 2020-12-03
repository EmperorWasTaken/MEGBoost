$(document).ready(function () {
    var price = new Vue({
        el: '#total_price',
        data: {
            CoachingPrice: 0,
            PlatformPrice: 0,
            PriceTotal: 0
        },
        watch: {
            CoachingPrice: function () {
                this.PriceTotal = parseInt(this.CoachingPrice) + parseInt(this.PlatformPrice)
            },
            Platform: function () {
                this.PriceTotal = parseInt(this.CoachingPrice) + parseInt(this.PlatformPrice)
            },
        },
        
    })
    var Coaching = new Vue({
        el: '#Coaching',
        data: {
            Coaching: '',
        },
        watch: {
            Coaching: function (){
                switch (this.Coaching){
                    case "1":
                        price.CoachingPrice = 20
                        break
                    case "2":
                        price.CoachingPrice = 35
                        break
                    case "3":
                        price.CoachingPrice = 65
                        break
                    case "4":
                        price.CoachingPrice = 140
                        break
                    case "5":
                        price.CoachingPrice = 265
                        break
                    case "6":
                        price.CoachingPrice = 510
                        break
                    case "7":
                        price.CoachingPrice = 975
                        break
                    default:
                        price.CoachingPrice = 0
                }
            }
        },
        
        
})
    var Platform = new Vue({
        el: '#Platform',
        data: {
            Platform: '',
        },
        watch: {
            Platform: function (){
                switch (this.Platform){
                    case "1":
                        price.PlatformPrice = price.CoachingPrice
                        break
                    case "2":
                        price.PlatformPrice = price.CoachingPrice * 1.2
                        break
                    case "3":
                        price.PlatformPrice = price.CoachingPrice * 1.2
                        break
                    default:
                        price.CoachingPrice = 0
                }
            }
        },
    })
})