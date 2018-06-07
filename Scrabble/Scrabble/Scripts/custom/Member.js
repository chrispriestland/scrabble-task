function genericMemberBegin() {
    $(".loading").fadeIn();
    $("#genericMemberResults").html("Loading...");
}
function genericMemberFailure() {
    $(".loading").fadeOut();
    $("#genericMemberResults").fadeIn();
    $("#genericMemberResults").html("An Error Occured");
}
function createMemberSuccess(data) {
    $(".loading").fadeOut();
    $("#genericMemberResults").fadeIn();
    $("#genericMemberResults").html("Create Member Result: " + data);
    if (data === "True") {
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
function updateMemberSuccess(data) {
    $(".loading").fadeOut();
    $("#genericMemberResults").fadeIn();
    $("#genericMemberResults").html("Update Member Result: " + data);
}
//# sourceMappingURL=Member.js.map