document.addEventListener('DOMContentLoaded', function () {
    Webcam.set({
        Width: 400,
        height: 350,
        image_format: 'jpeg',
        jpeg_quality: 90
    });

    var camera = document.getElementById("camera");

    if (camera) Webcam.attach(camera);

    document.getElementById('capture-btn').addEventListener('click', function () {
        Webcam.snap(function (data_uri) {
            document.getElementById('camera-container').style.display = 'none';
            document.getElementById('form-container').style.display = '';
            document.getElementById('captured-image').style.display = '';
            document.getElementById('captured-image').src = data_uri;
            document.getElementById('ImageData').value = data_uri;
        });
    });
});