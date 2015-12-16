function RemoveTR(e) {
    var element = e || $(this);

    element.parents("TR").remove();
}