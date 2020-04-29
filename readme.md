# Playfair

Playfair is a symmetric encryption method. This project contains implementation of Playfair algorithm with C#.

## Content

The solution contains two projects. One of them is server application and the other one is client application. Client application can load image, encrypt, save encrypted image and send to server with Socket.You should enter same ip address and port for both side. Server application, can decrypt and save image.

## Usage

Firstly, you should open both applications (server and client). After that at the server side enter ip address and port number and then click start server button. After that you can switch to client side. At the client side, you should open image. Image must be .bmp format. After click encrypt image button and you can see encrypted image on screen. If you want to save encrypted image to your computer, click save image button. Later on you should enter ip address and port number of server for socket. And click connect button later  and click send image button. Now you can see the encrypted image at the server side. Click decrypt button and you will see original image. If you want save the original image to your computer, click save encrypted image button.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)