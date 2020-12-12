$(document).ready(function () {
    var price = new Vue({
        el: '#total_price',
        data: {
            CoachingPrice: 0,
            PlatformPrice: 1,
            PriceTotal: 0
        },
        watch: {
            CoachingPrice: function () {
                this.PriceTotal = this.CoachingPrice * this.PlatformPrice
            },
            PlatformPrice: function () {
                this.PriceTotal = this.CoachingPrice * this.PlatformPrice
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
                        price.PlatformPrice = 1
                        PlatformName.formName = 'Bnet'
                        break
                    case "2":
                        price.PlatformPrice = 1.2
                        PlatformName.formName = 'Xbox'
                        break
                    case "3":
                        price.PlatformPrice = 1.2
                        PlatformName.formName = 'PSN'
                        break
                    default:
                        price.PlatformPrice = 0
                }
            }
        },
    })
    var PlatformName = new Vue({
        el: '#Platformname',
        data:{
            formName:'',
            platname:'Battle.net Username:'
        },
        watch:{
            formName: function (){
                switch (this.formName){
                    case "Bnet":
                        this.platname = 'Battle.net Username:'
                        break
                    case "PSN":
                        this.platname = 'PSN Username:'
                        break
                    case "Xbox":
                        this.platname = 'Xbox Username:'
                        break
                    default:
                        this.platname = 'Battle.net Username:'
                }
            },
        }
    })
})