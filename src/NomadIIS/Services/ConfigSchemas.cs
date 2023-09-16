﻿using Hashicorp.Nomad.Plugins.Shared.Hclspec;

namespace NomadIIS.Services;

public static class ConfigSchemas
{
	public static readonly Spec DriverConfig = new Spec()
	{
		Object = new Object()
		{
			Attributes =
			{
				{
					"enabled", new Spec()
					{
						Default = new Default()
						{
							Primary = new Spec()
							{
								Attr = new Attr()
								{
									Name = "enabled",
									Type = "bool",
									Required = false
								}
							},
							Default_ = new Spec()
							{
								Literal = new Literal()
								{
									Value = "true"
								}
							}
						}
					}
				},
				{
					"fingerprint_interval", new Spec()
					{
						Attr = new Attr()
						{
							Name = "fingerprint_interval",
							Type = "string",
							Required = false
						}
					}
				},
				{
					"directory_security", new Spec()
					{
						Default = new Default()
						{
							Primary = new Spec()
							{
								Attr = new Attr()
								{
									Name = "directory_security",
									Type = "bool",
									Required = false
								}
							},
							Default_ = new Spec()
							{
								Literal = new Literal()
								{
									Value = "true"
								}
							}
						}
					}
				},
			}
		}
	};

	public static readonly Spec TaskConfig = new Spec()
	{
		Object = new Object()
		{
			Attributes =
			{
				{
					"applications", new Spec()
					{
						BlockList = new BlockList()
						{
							Name = "application",
							MinItems = 1,
							Nested = new Spec()
							{
								Object = new Object()
								{
									Attributes =
									{
										{
											"alias", new Spec()
											{
												Attr = new Attr()
												{
													Name = "alias",
													Type = "string",
													Required = false
												}
											}
										},
										{
											"path", new Spec()
											{
												Attr = new Attr()
												{
													Name = "path",
													Type = "string",
													Required = true
												}
											}
										},
										{
											"enable_preload", new Spec()
											{
												Attr = new Attr()
												{
													Name = "enable_preload",
													Type = "bool",
													Required = false
												}
											}
										},
										{
											"virtual_directories", new Spec()
											{
												BlockList = new BlockList()
												{
													Name = "virtual_directory",
													Nested = new Spec()
													{
														Object = new Object()
														{
															Attributes =
															{
																{
																	"alias", new Spec()
																	{
																		Attr = new Attr()
																		{
																			Name = "alias",
																			Type = "string",
																			Required = true
																		}
																	}
																},
																{
																	"path", new Spec()
																	{
																		Attr = new Attr()
																		{
																			Name = "path",
																			Type = "string",
																			Required = true
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				},
				{
					"managed_pipeline_mode", new Spec()
					{
						Attr = new Attr()
						{
							Name = "managed_pipeline_mode",
							Type = "string",
							Required = false
						}
					}
				},
				{
					"managed_runtime_version", new Spec()
					{
						Attr = new Attr()
						{
							Name = "managed_runtime_version",
							Type = "string",
							Required = false
						}
					}
				},
				{
					"start_mode", new Spec()
					{
						Attr = new Attr()
						{
							Name = "start_mode",
							Type = "string",
							Required = false
						}
					}
				},
				{
					"idle_timeout", new Spec()
					{
						Attr = new Attr()
						{
							Name = "idle_timeout",
							Type = "string",
							Required = false
						}
					}
				},
				{
					"disable_overlapped_recycle", new Spec()
					{
						Attr = new Attr()
						{
							Name = "disable_overlapped_recycle",
							Type = "bool",
							Required = false
						}
					}
				},
				{
					"periodic_restart", new Spec()
					{
						Attr = new Attr()
						{
							Name = "periodic_restart",
							Type = "string",
							Required = false
						}
					}
				},
				{
					"bindings", new Spec()
					{
						BlockList = new BlockList()
						{
							Name = "binding",
							MinItems = 0,
							MaxItems = 2,
							Nested = new Spec()
							{
								Object = new Object()
								{
									Attributes =
									{
										{
											"type", new Spec()
											{
												Attr = new Attr()
												{
													Name = "type",
													Type = "string",
													Required = true
												}
											}
										},
										{
											"port", new Spec()
											{
												Attr = new Attr()
												{
													Name = "port",
													Type = "string",
													Required = true
												}
											}
										},
										{
											"hostname", new Spec()
											{
												Attr = new Attr()
												{
													Name = "hostname",
													Type = "string",
													Required = false
												}
											}
										},
										{
											"require_sni", new Spec()
											{
												Attr = new Attr()
												{
													Name = "require_sni",
													Type = "bool",
													Required = false
												}
											}
										},
										{
											"ip_address", new Spec()
											{
												Attr = new Attr()
												{
													Name = "ip_address",
													Type = "string",
													Required = false
												}
											}
										},
										{
											"certificate_hash", new Spec()
											{
												Attr = new Attr()
												{
													Name = "certificate_hash",
													Type = "string",
													Required = false
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	};
}
