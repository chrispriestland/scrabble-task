function genericMemberBegin(): void {
	$(".loading").fadeIn();
	$("#genericMemberResults").html("Loading...");
}

function genericMemberFailure(): void {
	$(".loading").fadeOut();
	$("#genericMemberResults").fadeIn();
	$("#genericMemberResults").html("An Error Occured");	
}

function createMemberSuccess(data): void {
	$(".loading").fadeOut();
	$("#genericMemberResults").fadeIn();
	$("#genericMemberResults").html(`Create Member Result: ${data}`);
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

function updateMemberSuccess(data): void {
	$(".loading").fadeOut();
	$("#genericMemberResults").fadeIn();
	$("#genericMemberResults").html(`Update Member Result: ${data}`);
}