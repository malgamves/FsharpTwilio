namespace WebApplication1.Controllers

open System.Web
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Twilio
open Twilio.Rest.Api.V2010.Account
open Twilio.Types
open Twilio.AspNet.Common;
open Twilio.AspNet.Mvc;
open Twilio.TwiML;
open Microsoft.AspNetCore.Mvc

[<Route("[controller]")>]
[<ApiController>]
type ValuesController () =
    inherit TwilioController()


    [<HttpGet>]
    member this.Get() =
        let values = [|"value1"; "value2"|]
        ActionResult<string[]>(values)

    [<HttpPost>]
    member this.Index (request : SmsRequest) =
        let response = MessagingResponse()
        response.Message "Hello World" |> ignore
        this.TwiML response