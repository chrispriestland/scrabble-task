function createMemberBegin() {
    $(".loading").fadeIn();
    $("#createMemberResults").html("Loading...");
}
function createMemberFailure() {
    $(".loading").fadeOut();
    $("#createMemberResults").fadeIn();
    $("#createMemberResults").html("An Error Occured");
}
function createMemberSuccess(data) {
    $(".loading").fadeOut();
    $("#createMemberResults").fadeIn();
    $("#createMemberResults").html("Create Member Result: " + data);
    if (data == "True") {
        $("#FirstName").val("");
        $("#LastName").val("");
        $("#TelephoneNumber").val("");
        $("#EmailAddress").val("");
        $("#Address1").val("");
        $("#Address2").val("");
        $("#City").val("");
        $("#Region").val("");
        $("#PostCode").val("");
    }
}
//# sourceMappingURL=Member.js.map