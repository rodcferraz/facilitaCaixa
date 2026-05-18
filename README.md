az aks get-credentials --resource-group rg-hackaton --name aks-hackaton


cat ~/.kube/config | base64 -w 0 > kubeconfig-base64.txt


kubectl exec -it dotnetsample-api-5b74d477fc-t5mhj -n production -- /bin/sh


kubectl port-forward svc/facilitacaixa-api-service 8080:80
