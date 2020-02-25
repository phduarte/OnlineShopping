# Online Shopping

### UML Component Diagram Example

An example of UML 2.5 component diagram for online shopping. The diagram shows "white-box" view of the internal structure of three related subsystems - WebStore, Warehouses, and Accounting. In UML «Subsystem» is a standard component stereotype for larger components, usually containing some smaller components.

![img](component-example-retail-website.png)

Online shopping UML component diagram example with three related subsystems - WebStore, Warehouses, and Accounting.

WebStore subsystem contains three components related to online shopping - Search Engine, Shopping Cart, and Authentication. Search Engine component allows to search or browse items by exposing provided interface Product Search and uses required interface Search Inventory provided by Inventory component. Shopping Cart component uses Manage Orders interface provided by Orders component during checkout. Authentication component allows customers to create account, login, or logout and binds customer to some account.

Accounting subsystem provides two interfaces - Manage Orders and Manage Customers. Delegation connectors link these external contracts of the subsystem to the realization of the contracts by Orders and Customers components.

Warehouses subsystem provides two interfaces Search Inventory and Manage Inventory used by other subsystems and wired through dependencies.

*Copyright © 2009-2020 uml-diagrams.org. All rights reserved.*

## Referências

[uml-diagrams.org](https://www.uml-diagrams.org/examples/online-shopping-uml-component-diagram-example.html?context=cmp-examples)