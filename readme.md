Spring-Interop-Samples
======================
Samples demonstrating Java <--> .NET interop scenarios leveraging vFabric components


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

    `C:\sqlfire-install-dir\bin> sqlf server start -dir=path-to-data-dir`   [can be an empty folder to start, but _must_ exist]

3. start `sqlf>` prompt via the following command-line:

    `C:\sqlfire-install-dir\bin> sqlf`

4. connect to the running server via the following command-line:

    `sqlf> connect client 'localhost:1527'`

5. run the script to create the SQLFire table and sequence via the following command-line (NOTE: path delimiters _must_ be passed as `/` instead of `\`):

    `sqlf> run 'path-to-project-repo/sqlfire_setup_scripts/sqlfire_create_schema.sql'`

6. run the script to populate the SEQUENCE with the initial value via the following command-line:

    `sqlf> run 'path-to-proejct-repo/sqlfire_setup_scripts/sqlfire_populate_data.sql'`

Launch Sample Applications (Java and .NET) 
------------------------------------------

The following .NET and Java application(s) must be running for the sample to function properly:

