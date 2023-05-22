document.addEventListener('DOMContentLoaded', (event) => {
    Webcam.set({
        Width: 400,
        height: 350,
        image_format: 'jpeg',
        jpeg_quality: 90
    });

    var camera = document.getElementById("camera");

    if (camera) Webcam.attach(camera);

    const captureButton = document.getElementById('capture-btn');
    const cameraContainer = document.getElementById('camera-container');
    const formContainer = document.getElementById('form-container');
    const imageDataInput = document.getElementById('ImageData');

    captureButton.addEventListener('click', () => {
        Webcam.snap(function (dataUri) {
            const capturedImage = document.getElementById('captured-image');
            capturedImage.src = dataUri;
            captureButton.style.display = 'none';
            cameraContainer.style.display = 'none';
            capturedImage.style.display = 'block';
            formContainer.style.display = 'block';
            localStorage.setItem('ImageData', dataUri);
        });
    });
});