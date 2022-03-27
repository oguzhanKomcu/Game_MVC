# ASP.NET MVC (.NET FRAMEWORK) 

<img src="https://erdincuzun.com/wp-content/uploads/2018/mvc_mimarisi.png" width="600" height="400">



It is a software architecture added to ASP.NET in 2007 with the development of web technologies.

The increase in the number of written codes and the lack of a suitable architecture for the developed application cause the code to become more complex and the code maintenance period to prolong. To solve this problem, Microsoft has integrated the MVC architecture, which is often used in web applications, into ASP.NET.

MVC, namely Model-View-Controller, is the simplest way to divide the developed applications into parts. The reason for partitioning is SOC Separation Of Concerns, that is, the principle of separation of responsibilities.


# WHAT IS MVC ( Model , View , Controller ) ?

<img src="https://user-images.githubusercontent.com/96787308/160289661-8599645d-db73-4a76-ba6d-49ac94c3e946.png" width="600" height="400">

### Model

In the MVC world the model is where application data or state is stored, usually in database or xml/json file format.
The model isolates the data layer (database, xml, json file, etc.) from the application so that other layers do not need to know where the data layer is.
The model layer is often used by Entity Framework, Nhibernate, LLBLGen, etc. created using tools such as

### View

The View is the layer that contains the interface that the client sees, usually created using data from the Model layer. By separating the View layer from the Model and Controller layers, interface changes can be made without the need to change other layers of the application.

It is possible to use the latest technologies such as HTML5 and CSS3 in the View layer. With HTML5 and CSS3, it has become very easy to develop applications that can run on desktop and mobile browsers. Even HTML5 and CSS3 technologies can be used to develop Windows Store applications.

### Controller

The Controller performs tasks such as processing the request from the client and bridging the Model and View layers. There can be one or more Actions in the Controller, usually each Action is used to generate a web page.


### Another important building block of MVC is the Routing mechanism.

### Routing

Routing is the structure that directs the client's request to the application to the appropriate Controller and Action. The client sends the request to a certain address of the application, the most suitable Controller for the relevant address and the Action in it are determined and run thanks to the routing mechanism.

### Why should I choose ASP.NET MVC?

With MVC, there is great control over the output produced in response to the client's request. In this way, it has been ensured that we can intervene in every field and that the most suitable output can be produced.

It is possible to generate reusable code with MVC. Since the layers of MVC are separated from each other, it is ensured that each layer can be used in other projects.

With MVC, the client has great control over the addresses to which it will send requests. In this way, it is ensured that the address is in a full relationship with the content. Since the address-content relationship is important for search engines, it contributes to the availability of the application.

Developing testable applications with MVC has become very easy. It is ensured that the layers are separate from each other and testable application can be developed thanks to the architecture that facilitates Test Driven Development.

### Conclusion

MVC is a mature pattern that has been used in many frameworks and programming languages ​​(Java, PHP, etc.) for many years. Thanks to ASP.NET MVC, it is possible to develop web applications that work fast, can be tested, and have reusable parts by using .Net framework languages ​​and MVC patterns.
