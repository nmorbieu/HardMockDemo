Here is some legacy code, probably written by a guy that was so dangerous when coding that he now is your manager :-) 

This code has to be refactored, but, as we are software craftman padawans, 
we don't want to touch anything without a good test harness.

The problem is that real integration tests are to instable and slow.

Let's use HardMock to fasten and stabilize integration tests.

1 - Write some integration tests
2 - Notice that they're very instable (results change every minute)
3 - Introduce interface on the dependency to allow HardMock to work
4 - Inject a recorder instead of the dependency in your integration tests, and persist method call results
5 - Replace the recorder by a replayer in the integration tests


HardMock rocks !
