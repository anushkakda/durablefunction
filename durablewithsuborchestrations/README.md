# Durable Function with SubOrchestration

- Here we can directly call another Orchestration function from one using the **CallSubOrchestratorAsync** method

- In this example, I used the same default orchestration functions and then called the Function2 orchestrator in Function1.

<br />


![SubOrchestration](./media/sub.PNG) 

<br />

- One of the used case could be when you have a switch statement and depending on the message a particular orchestrator has to be called.
