﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Ductus.FluentDocker.Extensions;

namespace Ductus.FluentDocker.Model.Containers
{
  public sealed class ContainerCreateParams
  {
    /// <summary>
    ///   Add a custom host-to-IP mapping (host:ip).
    /// </summary>
    /// <remarks>
    ///   --add-host=[]
    /// </remarks>
    public List<Tuple<string, IPAddress>> HostIpMappings { get; set; }

    /// <summary>
    ///   Block IO (relative weight), between 10 and 1000
    /// </summary>
    /// <remarks>
    ///   --blkio-weight
    /// </remarks>
    public int? BlockIoWeight { get; set; }

    /// <summary>
    ///   Block IO weight(relative device weight)
    /// </summary>
    /// <remarks>
    ///   --blkio-weight-device=[]
    /// </remarks>
    public string[] BlockIoWeightDevices { get; set; }

    /// <summary>
    ///   Add Linux capabilities
    /// </summary>
    /// <remarks>
    ///   --cap-add=[]
    /// </remarks>
    public string[] CapabilitiesToAdd { get; set; }

    /// <summary>
    ///   Drop Linux capabilities
    /// </summary>
    /// <remarks>
    ///   --cap-drop=[]
    /// </remarks>
    public string[] CapabilitiesToRemove { get; set; }

    /// <summary>
    ///   Optional parent cgroup for the container
    /// </summary>
    /// <remarks>
    ///   --cgroup-parent
    /// </remarks>
    public string ParentCGroup { get; set; }

    /// <summary>
    ///   Set environment variables
    /// </summary>
    /// <remarks>
    ///   -e, --env=[]
    /// </remarks>
    public string[] Environment { get; set; }

    /// <summary>
    ///   Read in a file of environment variables
    /// </summary>
    /// <remarks>
    ///   --env-file=[]
    /// </remarks>
    public string[] EnvironmentFiles { get; set; }

    /// <summary>
    ///   Keep STDIN open even if not attached
    /// </summary>
    /// <remarks>
    ///   -i, --interactive
    /// </remarks>
    public bool Interactive { get; set; }

    /// <summary>
    ///   Allocate a pseudo-TTY
    /// </summary>
    /// <remarks>
    ///   -t, --tty
    /// </remarks>
    public bool Tty { get; set; }

    /// <summary>
    ///   Assign a name to the container
    /// </summary>
    /// <remarks>
    ///   --name
    /// </remarks>
    public string Name { get; set; }

    /// <summary>
    ///   Username or UID (format: name|uid[:group|gid])
    /// </summary>
    /// <remarks>
    ///   -u, --user
    /// </remarks>
    public string AsUser { get; set; }

    /// <summary>
    ///   Automatically remove the container when it exits
    /// </summary>
    /// <remarks>
    ///   --rm
    /// </remarks>
    public bool AutoRemoveContainer { get; set; }

    /// <summary>
    ///   Bind mount a volume
    /// </summary>
    /// <remarks>
    ///   -v, --volume=[]
    /// </remarks>
    public string[] Volumes { get; set; }

    /// <summary>
    ///   Optional volume driver for the container
    /// </summary>
    /// <remarks>
    ///   --volume-driver
    /// </remarks>
    public string VolumeDriver { get; set; }

    /// <summary>
    ///   Mount volumes from the specified container(s)
    /// </summary>
    /// <remarks>
    ///   --volumes-from=[]
    /// </remarks>
    public string[] VolumesFrom { get; set; }

    /// <summary>
    ///   Working directory inside the container
    /// </summary>
    /// <remarks>
    ///   -w, --workdir
    /// </remarks>
    public string WorkingDirectory { get; set; }

    /// <summary>
    ///   Publish a container's port(s) to the host
    /// </summary>
    /// <remarks>
    ///   -p, --publish=[]
    /// </remarks>
    public string[] PortMappings { get; set; }

    /// <summary>
    ///   Publish all exposed ports to random ports
    /// </summary>
    /// <remarks>
    ///   -P, --publish-all. This is mutual exclusive when set to true,
    ///   the <see cref="PortMappings" /> is ignored.
    /// </remarks>
    public bool PublishAllPorts { get; set; }

    /// <summary>
    ///   Add link to another container
    /// </summary>
    /// <remarks>
    ///   --link=[]
    /// </remarks>
    public string[] Links { get; set; }

    /// <summary>
    ///   Set meta data on a container
    /// </summary>
    /// <remarks>
    ///   -l, --label=[]
    /// </remarks>
    public string[] Labels { get; set; }

    /// <summary>
    ///   Add additional groups to join
    /// </summary>
    /// <remarks>
    ///   --group-add=[]
    /// </remarks>
    public string[] Groups { get; set; }

    /// <summary>
    ///   Connect a container to a network
    /// </summary>
    /// <remarks>
    ///   --network
    /// </remarks>
    public string Network { get; set; }

    /// <summary>
    ///   Restart policy for this container.
    /// </summary>
    /// <remarks>
    ///   --restart
    /// </remarks>
    public RestartPolicy RestartPolicy { get; set; }

    /// <summary>
    ///   The maximum amount of memory the container can use. If you set this option, the minimum allowed value is 4m (4
    ///   megabyte).
    /// </summary>
    /// <remarks>
    ///   -m, --memory=
    /// </remarks>
    public string Memory { get; set; }

    /// <summary>
    ///   The amount of memory this container is allowed to swap to disk.
    /// </summary>
    /// <remarks>
    ///   --memory-swap *
    ///   --memory-swap is a modifier flag that only has meaning if --memory is also set. Using swap allows the container to
    ///   write excess memory requirements to disk when the container has exhausted all the RAM that is available to it. There
    ///   is a performance penalty for applications that swap memory to disk often.
    ///   Its setting can have complicated effects:
    ///   If --memory-swap is set to a positive integer, then both --memory and --memory-swap must be set. --memory-swap
    ///   represents the total amount of memory and swap that can be used, and --memory controls the amount used by non-swap
    ///   memory. So if --memory="300m" and --memory-swap="1g", the container can use 300m of memory and 700m (1g - 300m) swap.
    ///   If --memory-swap is set to 0, the setting is ignored, and the value is treated as unset.
    ///   If --memory-swap is set to the same value as --memory, and --memory is set to a positive integer, the container does
    ///   not have access to swap. See Prevent a container from using swap.
    ///   If --memory-swap is unset, and --memory is set, the container can use twice as much swap as the --memory setting, if
    ///   the host container has swap memory configured. For instance, if --memory="300m" and --memory-swap is not set, the
    ///   container can use 300m of memory and 600m of swap.
    ///   If --memory-swap is explicitly set to -1, the container is allowed to use unlimited swap, up to the amount available
    ///   on the host system.
    ///   Inside the container, tools like free report the host’s available swap, not what’s available inside the container.
    ///   Don’t rely on the output of free or similar tools to determine whether swap is present.
    /// </remarks>
    public string MemorySwap { get; set; }// TODO: https://docs.docker.com/config/containers/resource_constraints/#understand-the-risks-of-running-out-of-memory

    /// <summary>
    ///   Renders the argument string from this instance.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      if (null != HostIpMappings && 0 != HostIpMappings.Count)
      {
        sb.Append(" --add-host=");
        foreach (var mapping in HostIpMappings) sb.Append($"--add-host={mapping.Item1}:{mapping.Item2}");
      }

      if (null != BlockIoWeight) sb.Append($" --blkio-weight {BlockIoWeight.Value}");

      sb.OptionIfExists("--blkio-weight-device=", BlockIoWeightDevices);
      sb.OptionIfExists("--cap-add=", CapabilitiesToAdd);
      sb.OptionIfExists("--cap-drop=", CapabilitiesToRemove);
      sb.OptionIfExists("--cgroup-parent ", ParentCGroup);
      sb.OptionIfExists("-e ", Environment);
      sb.OptionIfExists("--env-file=", EnvironmentFiles);

      if (Interactive) sb.Append(" -i");

      if (Tty) sb.Append(" -t");

      sb.OptionIfExists("--name ", Name);
      sb.OptionIfExists("-u ", AsUser);

      if (AutoRemoveContainer) sb.Append(" --rm");

      sb.OptionIfExists("-v ", Volumes);
      sb.OptionIfExists("--volume-driver ", VolumeDriver);
      sb.OptionIfExists("--volumes-from=", VolumesFrom);
      sb.OptionIfExists("-w ", WorkingDirectory);

      if (!PublishAllPorts)
        sb.OptionIfExists("-p ", PortMappings);
      else
        sb.Append(" -P");

      sb.OptionIfExists("--link=", Links);
      sb.OptionIfExists("-l ", Labels);
      sb.OptionIfExists("--group-add=", Groups);
      sb.OptionIfExists("--network ", Network);

      if (RestartPolicy.No != RestartPolicy)
        switch (RestartPolicy)
        {
          case RestartPolicy.Always:
            sb.Append(" --restart always");
            break;
          case RestartPolicy.OnFailure:
            sb.Append(" --restart on-failure");
            break;
          case RestartPolicy.UnlessStopped:
            sb.Append(" --restart unless-stopped");
            break;
          default:
            sb.Append(" --restart no");
            break;
        }

      sb.SizeOptionIfValid("--memory=", Memory, 4 * 1024 * 1024 /*4m*/);

      return sb.ToString();
    }
  }

  /*
  --cpu-shares                    CPU shares (relative weight)
  --cidfile                       Write the container ID to the file
  --cpu-period                    Limit CPU CFS (Completely Fair Scheduler) period
  --cpu-quota                     Limit CPU CFS (Completely Fair Scheduler) quota
  --cpuset-cpus                   CPUs in which to allow execution (0-3, 0,1)
  --cpuset-mems                   MEMs in which to allow execution (0-3, 0,1)
  --detach-keys                   Override the key sequence for detaching a container
  --device=[]                     Add a host device to the container
  --device-read-bps=[]            Limit read rate (bytes per second) from a device
  --device-read-iops=[]           Limit read rate (IO per second) from a device
  --device-write-bps=[]           Limit write rate (bytes per second) to a device
  --device-write-iops=[]          Limit write rate (IO per second) to a device
  --disable-content-trust=true    Skip image verification
  --dns=[]                        Set custom DNS servers
  --dns-opt=[]                    Set DNS options
  --dns-search=[]                 Set custom DNS search domains
  --entrypoint                    Overwrite the default ENTRYPOINT of the image
  --expose=[]                     Expose a port or a range of ports
  -h, --hostname                  Container host name
  --ip                            Container IPv4 address (e.g. 172.30.100.104)
  --ip6                           Container IPv6 address (e.g. 2001:db8::33)
  --ipc                           IPC namespace to use
  --isolation                     Container isolation level
  --kernel-memory                 Kernel memory limit
  --label-file=[]                 Read in a line delimited file of labels
  --log-driver                    Logging driver for container
  --log-opt=[]                    Log driver options
  -m, --memory                    Memory limit
  --mac-address                   Container MAC address (e.g. 92:d0:c6:0a:29:33)
  --memory-reservation            Memory soft limit
  --memory-swap                   Swap limit equal to memory plus swap: '-1' to enable unlimited swap
  --memory-swappiness=-1          Tune container memory swappiness (0 to 100)
  --net=default                   Connect a container to a network
  --net-alias=[]                  Add network-scoped alias for the container
  --oom-kill-disable              Disable OOM Killer
  --oom-score-adj                 Tune host's OOM preferences (-1000 to 1000)
  --pid                           PID namespace to use
  --privileged                    Give extended privileges to this container
  --read-only                     Mount the container's root filesystem as read only
  --security-opt=[]               Security Options
  --shm-size                      Size of /dev/shm, default value is 64MB
  --sig-proxy=true                Proxy received signals to the process
  --stop-signal=15                Signal to stop a container, 15 by default
  --tmpfs=[]                      Mount a tmpfs directory
  --ulimit=[]                     Ulimit options
  --uts                           UTS namespace to use
*/
}