# K8S Task

### Task 01 - Install minikube
```sh
curl -LO https://storage.googleapis.com/minikube/releases/latest/minikube-linux-amd64
sudo install minikube-linux-amd64 /usr/local/bin/minikube && rm minikube-linux-amd64
```

### Task 02 - Set up K8S cluster, with RBAC enabled.
```
minikube start 
```

### Task 03 - Set up K8S cluster, with RBAC enabled.
```
# Set up K8S cluster RBAC configuration
```

### Task 04 - Create services
```
# Set up K8S cluster RBAC configuration
```

3.                  Cluster should have 2 services – A and B. 

4.                  Cluster should have Ingress controller, redirecting traffic by URL: xxx/service-A or xxx/service-B. 

5.                  Service-A should not be able to “talk” with Service-B (policy disabled). Netw

6.                  For Service A: write a script\application which retrieves the Bitcoin value in dollar from an API on the web (you should find one) every minute and prints it. 
In addition, every 10 minutes it should print the average value of the last 10 minutes. 
For Service B: Print "Hello!" or keep the default behavior of the service.