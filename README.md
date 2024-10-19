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
# Cluster should have 2 services – A and B
# Service-A: A Bitcoin price fetcher.
# Service-B: A simple web service that prints "Hello Microsoft!".
```

### Task 05 - Create Ingress controller
```
# Cluster should have Ingress controller, redirecting traffic by URL: xxx/service-A or xxx/service-B. 
```

### Task 06 - NetworkPolicy
```
# NetworkPolicy yaml file
```