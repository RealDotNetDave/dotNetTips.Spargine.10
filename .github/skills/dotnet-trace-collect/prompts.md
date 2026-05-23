# Copilot Prompts for the `dotnet-trace-collect` Skill

Use these prompts with the Copilot skill located at:

`/.github/skills/dotnet-trace-collect/skill.md`

This skill guides developers through choosing the right diagnostic tool and collecting performance traces for production .NET issues — including high CPU, memory leaks, slow requests, hangs, excessive GC, networking errors, and assembly loading failures — across Windows, Linux, containers, and Kubernetes.

---

## General Triage — I Don't Know Where to Start

```text
Use the dotnet-trace-collect skill to help me diagnose a production performance issue. I am seeing [describe symptom]. My app targets [.NET version], runs on [Windows/Linux], and is deployed [on a VM / in a container / in Kubernetes]. I [do / do not] have admin/root access. Tell me which diagnostic tool to use and give me the exact commands to collect data.
```

```text
Use the dotnet-trace-collect skill to help me choose the right diagnostic tool. My app is [.NET Framework / modern .NET version], running on [Windows / Linux], [with / without] admin access. The symptom is [describe symptom]. Walk me through tool selection and data collection.
```

---

## High CPU

```text
Use the dotnet-trace-collect skill to help me diagnose high CPU usage. My app targets .NET 10, runs on Windows, and I have admin access. Tell me whether to use PerfView or dotnet-trace, provide the exact collection command, and explain what to look for when I hand the trace to someone for analysis.
```

```text
Use the dotnet-trace-collect skill to collect a CPU trace on Linux for a .NET 10 application. I have root access. Recommend the right tool (dotnet-trace collect-linux vs dotnet-trace), provide the exact command, and describe the artifact handoff checklist.
```

```text
Use the dotnet-trace-collect skill to diagnose high CPU on a .NET 8 app running in a Linux container in Kubernetes. I do not have console access to the pod. Recommend dotnet-monitor and give me the commands to deploy it as a sidecar and trigger a CPU trace via the REST API.
```

---

## Memory Leaks

```text
Use the dotnet-trace-collect skill to help me diagnose a memory leak in a .NET 10 application on Windows. I have admin access. Walk me through capturing two process dumps for heap diff analysis in PerfView and tell me when and how to capture each dump.
```

```text
Use the dotnet-trace-collect skill to diagnose a memory leak on a pre-.NET 10 Linux application. I do not have root access. Explain whether dumps or traces are more useful, provide the collection commands, and describe the trade-offs.
```

```text
Use the dotnet-trace-collect skill to collect memory diagnostics for a .NET 10 app in a Linux container. I have console access inside the container and root access. Tell me how to capture two dumps for heap diff and run dotnet-trace collect-linux simultaneously to track allocations during the growth period.
```

---

## Slow Requests

```text
Use the dotnet-trace-collect skill to diagnose slow HTTP requests in an ASP.NET Core application on .NET 10, running on Windows with admin access. I need thread-time detail plus Kestrel request lifecycle events. Provide the exact PerfView command, including the /ThreadTime flag and ASP.NET Core providers.
```

```text
Use the dotnet-trace-collect skill to collect a slow-request trace for an ASP.NET Core app on Linux (.NET 10, root access). Provide the dotnet-trace collect-linux command with the thread-time profile and ASP.NET Core providers (Microsoft.AspNetCore.Hosting and Microsoft-AspNetCore-Server-Kestrel). Include PID discovery steps.
```

```text
Use the dotnet-trace-collect skill to diagnose slow requests for a .NET 8 application running in a Kubernetes pod. I do not have console access to the container. Recommend dotnet-monitor and show me how to capture a thread-time trace via the REST API.
```

---

## Hangs and Deadlocks

```text
Use the dotnet-trace-collect skill to diagnose a hang in a .NET 10 application on Windows with admin access. Walk me through the two-step approach: first a thread-time trace to detect livelocks and thread starvation, then a process dump if the trace does not reveal the cause.
```

```text
Use the dotnet-trace-collect skill to investigate a suspected deadlock in a .NET 8 app on Linux without root access. Explain whether dotnet-trace can identify the deadlock or whether a dump is needed, and provide the appropriate commands.
```

```text
Use the dotnet-trace-collect skill to diagnose a hang in a containerized .NET 10 application. I have console access. Recommend the best tool (dotnet-trace collect-linux or dotnet-trace), provide the thread-time trace command, and explain when to escalate to a dump.
```

---

## Excessive GC

```text
Use the dotnet-trace-collect skill to collect a GC-focused trace for a .NET 10 app on Windows. Provide the PerfView /GCCollectOnly command and explain what GC pause times and allocation patterns I should look for when handing the trace off for analysis.
```

```text
Use the dotnet-trace-collect skill to diagnose excessive GC on a .NET 8 Linux application without root access. Provide the dotnet-trace command with the gc-verbose profile.
```

```text
Use the dotnet-trace-collect skill to capture GC diagnostics for a containerized .NET 10 application where I do not have console access. Show me how to trigger a gc-verbose trace using the dotnet-monitor REST API.
```

---

## Networking Issues

```text
Use the dotnet-trace-collect skill to diagnose HTTP 5xx errors from a downstream service in a .NET 10 ASP.NET Core app on Windows with admin access. Provide the PerfView command with /ThreadTime and the System.Net.Http, System.Net.NameResolution, System.Net.Security, and System.Net.Sockets providers. Explain which events to look for (RequestStart, RequestStop with statusCode -1, RequestFailed, RequestLeftQueue).
```

```text
Use the dotnet-trace-collect skill to diagnose connection timeouts in a .NET 10 app on Linux with root access. Provide the dotnet-trace collect-linux command with the thread-time profile and the four System.Net.* providers. Include PID discovery steps and the artifact handoff checklist.
```

```text
Use the dotnet-trace-collect skill to diagnose TLS handshake failures in a .NET 8 app running in Kubernetes without console access. Show me how to trigger a thread-time trace with System.Net.Security and System.Net.Http providers via the dotnet-monitor REST API.
```

```text
Use the dotnet-trace-collect skill to diagnose connection pool exhaustion in a .NET 10 app on Linux without root access. Explain which networking providers to enable, provide the dotnet-trace command, and tell me which RequestLeftQueue events to look for in the trace.
```

---

## Assembly Loading Issues

```text
Use the dotnet-trace-collect skill to diagnose a FileNotFoundException on startup in a .NET 10 app on Linux. The process exits before I can attach by PID. Show me how to use dotnet-trace in launch mode (-- <path>) with the --clrevents assemblyloader flag to capture the full assembly binding sequence.
```

```text
Use the dotnet-trace-collect skill to investigate duplicate assembly loads across AssemblyLoadContexts in a .NET 10 app on Windows with admin access. Provide the PerfView collect command for assembly loader events and explain what to look for in the trace.
```

```text
Use the dotnet-trace-collect skill to capture assembly loader binder events for a .NET 10 app in a Linux container with root access. Provide the dotnet-trace collect-linux command with --clrevents assemblyloader and include the artifact handoff checklist.
```

---

## Long-Running Repros (Trigger-Based Collection)

```text
Use the dotnet-trace-collect skill to collect a PerfView trace for an issue that takes hours to manifest on Windows. Show me how to configure a /StopOn trigger that fires on the symptom (not recovery), with a circular buffer (/CircularMB and /BufferSizeMB), so I capture the interesting behavior without generating huge trace files.
```

```text
Use the dotnet-trace-collect skill to set up a trigger-based PerfView collection for a memory growth issue on .NET 10 Windows with admin access. The issue manifests after several hours of load. Recommend the right /StopOn trigger (GC event, performance counter, or exception), and explain why the trigger must fire on the symptom rather than the recovery.
```

---

## Container and Kubernetes Scenarios

```text
Use the dotnet-trace-collect skill to set up dotnet-monitor as a sidecar in a Kubernetes deployment for a .NET 10 app. Provide the sidecar container spec, the shared diagnostic port configuration (/tmp Unix domain socket), and the kubectl port-forward command to access the REST API securely.
```

```text
Use the dotnet-trace-collect skill to collect a dotnet-trace from inside a running container in Kubernetes where I have console access via kubectl exec. Walk me through PID discovery (dotnet-trace ps), installing dotnet-trace if it is not in the image, and copying the trace out using kubectl cp.
```

---

## .NET Framework Scenarios

```text
Use the dotnet-trace-collect skill to diagnose high CPU in a .NET Framework 4.8 application on Windows with admin access. I know dotnet-trace does not support .NET Framework — confirm I should use PerfView and provide the exact PerfView collect command.
```

```text
Use the dotnet-trace-collect skill to diagnose a memory leak in a .NET Framework 4.8 app on Windows. I do not have admin access. Explain what I can and cannot diagnose without admin, and tell me how to capture a process dump using Task Manager or procdump as a fallback.
```

---

## Artifact Handoff

```text
Use the dotnet-trace-collect skill to generate the artifact handoff checklist for the trace I just collected. I need to send the .nettrace file to another engineer for analysis. Tell me exactly what metadata to include: runtime version, OS, kernel version, container image tag or build SHA, PID and process name, UTC start/end timestamps, the exact collection command used, and the artifact path.
```

---

## Spargine-Style Diagnostics Prompt

```text
Use the dotnet-trace-collect skill to collect production diagnostics for a Spargine-based .NET 10 application. The app runs on Linux in a Kubernetes pod where I have console access and root access inside the container.

The symptom is [describe symptom: high CPU / memory growth / slow requests / hang / excessive GC / networking errors / assembly loading failures].

Apply these constraints:
- Prefer dotnet-trace collect-linux (richer traces with native stacks on .NET 10+ with root).
- Include ASP.NET Core providers (Microsoft.AspNetCore.Hosting, Microsoft-AspNetCore-Server-Kestrel) for slow-request scenarios.
- Include all four System.Net.* providers for networking scenarios.
- Use --clrevents assemblyloader for assembly loading issues; prefer launch mode if the process is short-lived.
- Always verify PID with dotnet-trace ps before attaching.
- Provide the artifact handoff checklist.
- Recommend the analysis tool (PerfView or Speedscope) for the collected .nettrace file.
```
