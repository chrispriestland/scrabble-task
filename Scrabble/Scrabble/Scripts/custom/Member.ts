function createMemberBegin(): void {
	$(".loading").fadeIn();
	$("#createMemberResults").html("Loading...");
}

function createMemberFailure(): void {
	$(".loading").fadeOut();
	$("#createMemberResults").fadeIn()
	$("#createMemberResults").html("An Error Occured");	
}

function createMemberSuccess(data): void {
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