import * as signalR from '@microsoft/signalr';

var connection = new signalR.HubConnectionBuilder()
    .withUrl("https://example.com/quizhub")
    .build();

connection.on("ReceiveQuestion", function(question, answers) {
    // process the question and answers
});