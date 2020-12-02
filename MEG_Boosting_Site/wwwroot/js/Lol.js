$(document).ready(function (){
    var RankPlayer = new Vue({
        el: '#PlayerRank',
        data: {
            playerrank: '',
            flip: '',
            playerdivision: '',
        },
        watch: {
          playerdivision: function (){
              switch (this.playerdivision){
                  case "I":
                      pris.PlayerDivPris = -15
                      break
                  case "II":
                      pris.PlayerDivPris = -10
                      break
                  case "III":
                      pris.PlayerDivPris = -5
                      break
                  case "IV":
                      pris.PlayerDivPris = 0
                      break
                  default:
                      pris.PlayerDivPris = 0
              }
          }  
        },
       methods:{
            lolrankcheck(e){
                switch (e.target.value){
                    case "Iron":
                        this.flip = true
                        pris.PlayerRankPris = 100
                        break
                    case "Bronze":
                        this.flip = true
                        pris.PlayerRankPris = 80
                        break
                    case "Silver":
                        this.flip = true
                        pris.PlayerRankPris = 60
                        break
                    case "Gold":
                        this.flip = true
                        pris.PlayerRankPris = 40
                        break
                    case "Platinum":
                        this.flip = true
                        pris.PlayerRankPris = 30
                        break
                    case "Diamond":
                        this.flip = true
                        pris.PlayerRankPris = 20
                        break
                    case "Master":
                        this.flip = false
                        pris.PlayerRankPris = 15
                        pris.PlayerDivPris = 0
                        break
                    case "Grandmaster":
                        this.flip = false
                        pris.PlayerRankPris = 10
                        pris.PlayerDivPris = 0
                        break
                    case "Challenger":
                        this.flip = false
                        pris.PlayerRankPris = 5
                        pris.PlayerDivPris = 0
                        break
                    default:
                        this.flip = false
                }
            }
       }
    })
    var RankBoost = new Vue({
        el: '#BoostRank',
        data: {
            boostrank: '',
            flip: '',
            boostdivision: '',
        },
        watch: {
            boostdivision: function (){
                switch (this.boostdivision){
                    case "I":
                        pris.BoostDivPris = 15
                        break
                    case "II":
                        pris.BoostDivPris = 10
                        break
                    case "III":
                        pris.BoostDivPris = 5
                        break
                    case "IV":
                        pris.BoostDivPris = 0
                        break
                    default:
                        pris.BoostDivPris = 0
                }
            }
        },
        methods:{
            boostrankcheck(e){
                switch (e.target.value){
                    case "Iron":
                        this.flip = true
                        pris.BoostRankPris = 10
                        break
                    case "Bronze":
                        this.flip = true
                        pris.BoostRankPris = 15
                        break
                    case "Silver":
                        this.flip = true
                        pris.BoostRankPris = 20
                        break
                    case "Gold":
                        this.flip = true
                        pris.BoostRankPris = 25
                        break
                    case "Platinum":
                        this.flip = true
                        pris.BoostRankPris = 30
                        break
                    case "Diamond":
                        this.flip = true
                        pris.BoostRankPris = 35
                        break
                    case "Master":
                        this.flip = false
                        pris.BoostRankPris = 100
                        pris.BoostDivPris = 0
                        break
                    case "Grandmaster":
                        this.flip = false
                        pris.BoostRankPris = 200
                        pris.BoostDivPris = 0
                        break
                    case "Challenger":
                        this.flip = false
                        pris.BoostRankPris = 500
                        pris.BoostDivPris = 0
                        break
                    default:
                        this.flip = false
                }
            }
        }
    })
    var pris = new Vue({
        el: '#PrisTest',
        data:{
            PlayerRankPris: 0,
            BoostRankPris: 0,
            PlayerDivPris: 0,
            BoostDivPris: 0,
            PrisTotal: 0
        },
        watch: {
            PlayerRankPris: function(){
                this.PrisTotal = this.PlayerRankPris + this.BoostRankPris + this.PlayerDivPris + this.BoostDivPris
            },
            BoostRankPris: function(){
                this.PrisTotal = this.PlayerRankPris + this.BoostRankPris + this.PlayerDivPris + this.BoostDivPris
            },
            PlayerDivPris: function (){
                this.PrisTotal = this.PlayerRankPris + this.BoostRankPris + this.PlayerDivPris + this.BoostDivPris  
            },
            BoostDivPris: function (){
                this.PrisTotal = this.PlayerRankPris + this.BoostRankPris + this.PlayerDivPris + this.BoostDivPris
            }
        },
    })
    var winsBoost = new Vue({
        el: '#winsSlider',
        data:{
            winsslide: '',
            duoboost: false,
            winsAmount: 0,
            winsPrice: 0
        },
        watch: {
            winsslide: function (){
                this.winsAmount = parseInt(this.winsslide)
                if(this.duoboost === true){
                    this.winsPrice = this.winsAmount * 10 * 1.5
                }
                else{
                    this.winsPrice = this.winsAmount * 10
                }
            },
            duoboost: function (){
                this.winsAmount = parseInt(this.winsslide)
                if(this.duoboost === true){
                    this.winsPrice = this.winsAmount * 10 * 1.5
                }
                else{
                    this.winsPrice = this.winsAmount * 10
                }
            }
        }
    })
})