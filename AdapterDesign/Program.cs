#region Class Adapter

ITarget adapter_CA = new ClassAdapter();

// Create a client and pass the adapter to it
ClientClassAdapter client_CA = new ClientClassAdapter(adapter_CA);

// Make a request using the client
client_CA.MakeRequest();

#endregion

#region Object Adapter
Adaptee adaptee = new Adaptee();

// Create an instance of the ObjectAdapter and pass the Adaptee to it
ITarget adapter_OA = new ObjectAdapter(adaptee);

// Execute the request using the adapter
ClientObjectAdapter client_OA = new ClientObjectAdapter();
client_OA.ExecuteRequest(adapter_OA);

#endregion