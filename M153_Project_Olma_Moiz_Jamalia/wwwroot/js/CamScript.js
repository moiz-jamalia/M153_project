document.addEventListener('DOMContentLoaded', function () {
    Webcam.set({
        Width: 400,
        height: 350,
        image_format: 'jpeg',
        jpeg_quality: 90
    });

    var camera = document.getElementById("camera");

    if (camera) Webcam.attach(camera);
})

document.addEventListener('CaptureImage', function () {
    
})