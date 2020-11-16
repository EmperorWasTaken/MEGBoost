$(document).ready(function (){
    var Ranked = new Vue({
        el: '#PlayerRank',
        data: {
            playerrank: '',
            flip: '',
            playerdivision: ''
        },
       methods:{
            lolrankcheck(e){
                switch (e.target.value){
                    case "Iron":
                        this.flip = true
                        break
                    case "Bronze":
                        this.flip = true
                        break
                    case "Silver":
                        this.flip = true
                        break
                    case "Gold":
                        this.flip = true
                        break
                    case "Platinum":
                        this.flip = true
                        break
                    case "Diamond":
                        this.flip = true
                        break
                    default:
                        this.flip = false
                }
            }
       }
    })
})

$(document).ready(function (){
    var Ranked = new Vue({
        el: '#BoostRank',
        data: {
            boostrank: '',
            flip: '',
            boostdivision: ''
        },
        methods:{
            boostrankcheck(e){
                switch (e.target.value){
                    case "Iron":
                        this.flip = true
                        break
                    case "Bronze":
                        this.flip = true
                        break
                    case "Silver":
                        this.flip = true
                        break
                    case "Gold":
                        this.flip = true
                        break
                    case "Platinum":
                        this.flip = true
                        break
                    case "Diamond":
                        this.flip = true
                        break
                    default:
                        this.flip = false
                }
                
            }
        }
    })
})
