Spring-Interop-Samples
======================
Samples demonstrating Java and .NET interop scenarios leveraging Spring support for vFabric components


Setup/Install/Configure required vFabric servers/services
---------------------------------------------------------

The following vFabric components (Windows releases) must be installed and functional to run this sample:

* RabbitMQ (2.6.1)
* GemFire (v6.6)
* SQLFire (1.0 BETA)


### Rabbit Setup Steps

1. install RabbitMQ service as per the RabbitMQ installation/getting-started instructions (recommended but not necessary: add the admin plugin, see http://www.rabbitmq.com/management.html)
2. start RabbitMQ service (windows Services control panel or command-line as preferred)
3. verify RabbitMQ service is running via the following command-line (switch to `rabbit-install-dir\sbin\`):

    C:\rabbitDir\sbin> rabbitmqctl status

4. If mgt plugin added, nav to RabbitMQ web admin portal (http://localhost:55672  [default creds: username=guest, password=guest)

### GemFire Setup Steps


1. Install GemFire as per the GemFire installation/getting-started instructions
2. copy the `cache.xml` file from `path-to-project-repo\gemfire-config\` to the `gemfire-install-dir\bin\` folder
3. start GemFire via the following command-line (switch to `gemfire-install-dir\bin\`):

    `C:\gemfire-install-dir\bin> cacheserver start`

4. verify GemFire started via the following command-line:

    `C:\gemfire-install-dir\bin> cacheserver status`

### SQLFire Setup Steps

1. Install SQLFire as per the SQLFire installation/getting-started instructions
2. start the server via the following command-line (switch to `sqlfire-install-dir\bin\`):

    `C:\sqlfire-install-dir\bin> sqlf server start -dir=path-to-data-dir` [note: _path-to-data-dir_ can be an empty folder, but the folder _must_ already exist]

3. start `sqlf>` prompt via the following command-line:

    `C:\sqlfire-install-dir\bin> sqlf`

4. connect to the running server via the following command-line:

    `sqlf> connect client 'localhost:1527'`

[note: single quotes must surround the _hostname:portnumber_ argument as shown]

5. run the script to create the SQLFire table and sequence via the following command-line (note: even on Windows OS, the path delimiters _must_ be passed as `/` instead of `\`):

    `sqlf> run 'path-to-project-repo/sqlfire_setup_scripts/sqlfire_create_schema.sql'`

[note: single quotes must surround the _file-to-run_ argument as shown]

6. run the script to populate the SEQUENCE with the initial value via the following command-line:

    `sqlf> run 'path-to-project-repo/sqlfire_setup_scripts/sqlfire_populate_data.sql'`

[note: single quotes must surround the _file-to-run_ argument as shown]

Launch Sample Applications (Java and .NET) 
------------------------------------------

The following .NET and Java application(s) must be running for the sample to function properly:

* Java Server App
* .NET Windows Forms Client App
* .NET ASP.NET MVC Web Trade Reporter App
* .NET Credit Check REST service endpoint (hosted in ASP.NET MVC App)

The default configuration settings for these applications assume all are to be deployed on the same computer, but these applications can be deployed on the same or different computers from each other (some configuration changes will be needed for deployment to multiple systems).

### Starting the Java Server App

1. Open the project `path-to-project-repo/java/stocks/` in SpringSource Tool Suite (or another Java IDE of your choice)
2. Run the `Server.java` package located in `path-to-project-repo/java/stocks/src/test/java/org/springframework/amqp/rabbit/stocks`

### Starting the .NET Windows Forms Client App
1. Open the `path-to-project-repo\net\StockTraderSample\Spring.Interop.StockTraderSample.sln` file in Visual Studio 2010 or later
2. Launch a DEBUG instance of the `Spring.Interop.StockTraderSample.Client.2010` project (right-click on the project in the Solution Explorer window and select `Debug --> Start new instance`)
3. Launch a DEBUG instance of the `Spring.Interop.StockTraderSample.ReportingWebApp.2010` project (right-click on the project in the Solution Explorer window and select `Debug --> Start new instance`).  By default this web application will listen on PORT 1000.
4. Launch a DEBUG instance of the `Spring.Interop.StockTraderSample.CreditCheckService.2010` project (right-click on the project in the Solution Explorer window and select `Debug --> Start new instance`).  By default this web application will listen on PORT 1100.

Interacting with the Sample Applications
----------------------------------------

### Java Server App
* The Java Server App contains no UI; once it is started, it will begin broadcasting stock _QUOTE_ messages and listening for stock _BUY_ and _SELL_ messages.

### .NET Windows Forms Client App
* Use the _START_ and _STOP_ buttons to control the client listening for stock _QUOTE_ messages from the Java-based server.
* Change the value in the _Routing Key_ textbox and click the _APPLY_ button to change the filtering of _QUOTE_ messages received; this filtering is not merely applied to the listbox displaying the quotes, but controls the scope of the _QUOTE_ messages that are received by the client from the server.
* To submit a _BUY_ or _SELL_ message to the server enter a valid stock ticker symbol into the _Symbol_ textbox.  For the purposes of this sample system, only stock ticker symbols that appear in the quotes listbox are considered valid by the system.  Next, select either the _Buy_ or _Sell_ radio button, enter a quantity into the numeric control, and click the _Send Trade Request_ button.  This message will be received by the Java Server App, processed, and a response message returned to the Client App.  If there are any errors, these will be returned to the Client App via messages from the Server App as well.

### .NET ASP.NET MVC Web Trade Reporter App
* Navigate to the application using your web browser of choice.  By default, the application will be running at the http://localhost:1000/ URL.
* Click on the _Activity Report_ tab to access the trade history data stored in SQLFire.

### .NET Credit Check REST service endpoint
* Although this HTTP endpoint is hosted in an ASP.NET MVC application, there is no expected interaction with it via a UI.
* When the Java Server App processes a _BUY_ message from the Client App, the Java Server App makes a call to this application to peform a credit check on the intended purchase.  This service is hard-coded to accept any _BUY_ order with a total value under $10,000 and to reject any _BUY_ order with a value larger than that.

