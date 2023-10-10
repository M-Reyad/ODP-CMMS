ODP-CMMS is an Oracle DB integrated with winform C# Windows Application (Uppon ODP Request and can be done with a Cloud Based/ Web Application with any selected Language)
The created CMMS integrates the three main Departments (Maintenace and Repair/ Finance/ Stores Management) and can be interpretted as an ERP system.
The reason why I advised you to have at leat a team member related to Maintenance Activities is that he can emphasize the whole core Moduels to his team and the coordination between them.

![Login Page](https://github.com/M-Reyad/ODP-2/assets/93882864/92ac4da2-7604-4853-8c01-2b76aea9fa6e)
![Home](https://github.com/M-Reyad/ODP-2/assets/93882864/d49ae2a5-2f47-47f3-8d82-cf70c5bdbe7d)

Let me explain the Core Modules for the implemented CMMS before for ODP;
    1- Work Order Management
        a. Creating new Work Order to Manage the Maintenance Operations (PM/CM/PCM/OH/INS…)
        b. Querying Closed/ Active Work Orders with multi search inputs.
        ![Active Work Order Search Results](https://github.com/M-Reyad/ODP-2/assets/93882864/2b9ce764-5788-45a0-9b57-b6a90a95f396)
    2- Work Order Module
        a. Contain all work Order Data
            i. Work Order Status (Request/ Started/ Done/ Closed)
            ii. Registration Date, Work Start, End Date and Closing Date
            iii. Equipment Running Hours
            iv. Work Order Creator.
        b. Request/Allocate Materials (Oils/ Filters/ Spare Parts) to be issued on
        c. Register Work Done notes and Performed Actions.
        d. Record Down time in order to facilitate the KPIs Measurements.
        e. Register Warranty Claims for new Equipment.
        f. Registed Returned repairable Spare Parts to be added to Inventory Spare parts after being Repaired/ Overhauled.
            ![Work Order - Materials](https://github.com/M-Reyad/ODP-2/assets/93882864/7cadcea4-82b7-4aa8-99dd-f4c62d7dde2e)
            ![Work Order - Breakdowns](https://github.com/M-Reyad/ODP-2/assets/93882864/0a9ea195-94cd-4915-bd99-cd1c87562e0c)
            ![Work Order - Work Done](https://github.com/M-Reyad/ODP-2/assets/93882864/1a593b17-3608-4b82-9f33-75b244f9c58a)
    3- Inventory Spare Parts Module to
        a. Check the availability and the Stock Count of Spare Parts.
        ![Inventory Parts Registeration](https://github.com/M-Reyad/ODP-2/assets/93882864/a91cf1bd-4f19-4657-a484-dd5a8c80a82e)
        b. Check the Allocated count of Spare Parts and the Work Orders allocated on.
        ![Inventory Parts Allocation](https://github.com/M-Reyad/ODP-2/assets/93882864/dbc30190-b0c0-4f45-b93c-54e94a321536)
    4- Fuel Station to record all Incoming Shipping/ Fuel Issueing on Assets (Utilities/ Equipment and Facilities)
    ![Fuel Station Records](https://github.com/M-Reyad/ODP-2/assets/93882864/8c616e0d-30cd-4d8b-9faa-3b5d8bc85eba)
    5- Stores Module to issue/ Un-issue spare parts and Finance Transactions Module.
    ![Stores - Issueing Materials](https://github.com/M-Reyad/ODP-2/assets/93882864/530dc737-21cb-4228-9118-d71116df59c9)
    ![Stores - Unissueing Materials 2](https://github.com/M-Reyad/ODP-2/assets/93882864/172846b5-8214-4a7c-a32c-663b1ededf7a)
    6- Asset Management Module to
        a. Record all the Assets with their Unique Components with their Serial Numbers.
        b. Define Assets Status (On Operation/ Breakdown/ Hibernated).
        ![Asset Record](https://github.com/M-Reyad/ODP-2/assets/93882864/f86a43e3-9006-4cab-a89a-0fd408b0d689)
        c. Assets Running Hours Registeration.
        ![Equipment Running Hours Registeration](https://github.com/M-Reyad/ODP-2/assets/93882864/c50d5f78-b48c-4ce2-9bf5-ee08e697ad58)
        d. PM Work Orders Generation
        ![PM Generation System](https://github.com/M-Reyad/ODP-2/assets/93882864/53b3cf92-910b-4827-83ee-592cfd7e15d3)
        e. Templates Work Orders Registration.
    7- KPIs, OPEX and Budgeting to record the whole annual Budget and Operational Expenditures so that to have an accurate Financial KPIs calculation.
  ![Budget and OPEX](https://github.com/M-Reyad/ODP-2/assets/93882864/0539c12f-0347-437e-93be-918fd23ce891)
