# Yolo-Holo WinML Sample
 Implementation of sample for Microsoft Hololens e Windows Machine Learning to use TinyYOLO v2 (You-Only-Look-Once). For details on YOLO, check out the inventor's site - https://pjreddie.com/darknet/yolo/

Updated to work with the last release of Win ML. 

Windows Machine Learning implementation using TinyYOLO v2 (You-Only-Look-Once). For details on YOLO, check out to https://pjreddie.com/darknet/yolo/

# Acknowledgements
This sample project was based on work by https://elbruno.com/2018/06/28/winml-how-to-create-a-windows10-app-using-yolo-for-object-detection/ and https://github.com/sevans4067/WinMl-TinyYOLO

# Setup
To try out the pre-released Windows ML, you'll need the Windows 10 SDK (Build 17763 or higher).

If running on desktop Windows, you'll need to set your configuration to x86 or x64.

# Model
The tiny-yolov2-1.2.onnx model embedded with this project was created from the model located at https://gallery.azure.ai/Model/Tiny-YOLOv2-1-2-3. This model represents YOLOv2 1.2, and was built off the classes in the Pascal VOC project. See https://github.com/onnx/onnxmltools for more information on how to convert models to ONNX.

Windows ML requires ONNX models, version 1.2 or higher - https://docs.microsoft.com/en-us/windows/ai/get-onnx-model