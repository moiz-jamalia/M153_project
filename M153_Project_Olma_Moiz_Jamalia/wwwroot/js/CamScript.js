document.addEventListener('DOMContentLoaded', function () {
    Webcam.set({
        Width: 320,
        height: 240,
        image_format: 'jpeg',
        jpeg_quality: 90
    });

    var camera = document.getElementById("camera");

    if (camera) Webcam.attach(camera);


    
})