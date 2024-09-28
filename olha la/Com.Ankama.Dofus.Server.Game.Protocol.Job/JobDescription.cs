using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000367")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobDescription : IMessage<JobDescription>, IMessage, IEquatable<JobDescription>, IDeepCloneable<JobDescription>, IBufferMessage
{
	[Token(Token = "0x2000368")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000369")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class SkillAction : IMessage<SkillAction>, IMessage, IEquatable<SkillAction>, IDeepCloneable<SkillAction>, IBufferMessage
		{
			[Token(Token = "0x200036A")]
			public enum ActionOneofCase
			{
				[Token(Token = "0x4000BBF")]
				None = 0,
				[Token(Token = "0x4000BC0")]
				Timed = 2,
				[Token(Token = "0x4000BC1")]
				Craft = 3
			}

			[Token(Token = "0x200036B")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x200036C")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class Timed : IMessage<Timed>, IMessage, IEquatable<Timed>, IDeepCloneable<Timed>, IBufferMessage
				{
					[Token(Token = "0x200036D")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static class Types
					{
						[Token(Token = "0x200036E")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class Collect : IMessage<Collect>, IMessage, IEquatable<Collect>, IDeepCloneable<Collect>, IBufferMessage
						{
							[Token(Token = "0x4000BC8")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<Collect> _parser;

							[Token(Token = "0x4000BC9")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x4000BCA")]
							public const int MinFieldNumber = 1;

							[Token(Token = "0x4000BCB")]
							[FieldOffset(Offset = "0x18")]
							private int min_;

							[Token(Token = "0x4000BCC")]
							public const int MaxFieldNumber = 2;

							[Token(Token = "0x4000BCD")]
							[FieldOffset(Offset = "0x1C")]
							private int max_;

							[Token(Token = "0x17000799")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageParser<Collect> Parser
							{
								[Token(Token = "0x600237B")]
								[Address(RVA = "0x969430", Offset = "0x968830", VA = "0x180969430")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x1700079A")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x600237C")]
								[Address(RVA = "0x9693B0", Offset = "0x9687B0", VA = "0x1809693B0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x1700079B")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x600237D")]
								[Address(RVA = "0x969500", Offset = "0x968900", VA = "0x180969500", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x1700079C")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public int Min
							{
								[Token(Token = "0x6002381")]
								[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x6002382")]
								[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
								set
								{
								}
							}

							[Token(Token = "0x1700079D")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int Max
							{
								[Token(Token = "0x6002383")]
								[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
								get
								{
									return default(int);
								}
								[Token(Token = "0x6002384")]
								[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
								set
								{
								}
							}

							[Token(Token = "0x600237E")]
							[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Collect()
							{
							}

							[Token(Token = "0x600237F")]
							[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public Collect(Collect other)
							{
							}

							[Token(Token = "0x6002380")]
							[Address(RVA = "0x9690A0", Offset = "0x9684A0", VA = "0x1809690A0", Slot = "10")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public Collect Clone()
							{
								return null;
							}

							[Token(Token = "0x6002385")]
							[Address(RVA = "0x969130", Offset = "0x968530", VA = "0x180969130", Slot = "0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x6002386")]
							[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public bool Equals(Collect other)
							{
								return default(bool);
							}

							[Token(Token = "0x6002387")]
							[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x6002388")]
							[Address(RVA = "0x969250", Offset = "0x968650", VA = "0x180969250", Slot = "3")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x6002389")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x600238A")]
							[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x600238B")]
							[Address(RVA = "0x968FE0", Offset = "0x9683E0", VA = "0x180968FE0", Slot = "7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x600238C")]
							[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(Collect other)
							{
							}

							[Token(Token = "0x600238D")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x600238E")]
							[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}
					}

					[Token(Token = "0x4000BC2")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<Timed> _parser;

					[Token(Token = "0x4000BC3")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4000BC4")]
					public const int TimeFieldNumber = 1;

					[Token(Token = "0x4000BC5")]
					[FieldOffset(Offset = "0x18")]
					private int time_;

					[Token(Token = "0x4000BC6")]
					public const int CollectFieldNumber = 2;

					[Token(Token = "0x4000BC7")]
					[FieldOffset(Offset = "0x20")]
					private Types.Collect collect_;

					[Token(Token = "0x17000794")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<Timed> Parser
					{
						[Token(Token = "0x6002366")]
						[Address(RVA = "0x9809E0", Offset = "0x97FDE0", VA = "0x1809809E0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000795")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6002367")]
						[Address(RVA = "0x980960", Offset = "0x97FD60", VA = "0x180980960")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000796")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6002368")]
						[Address(RVA = "0x980B50", Offset = "0x97FF50", VA = "0x180980B50", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x17000797")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int Time
					{
						[Token(Token = "0x600236C")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x600236D")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x17000798")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Types.Collect Collect
					{
						[Token(Token = "0x600236E")]
						[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
						get
						{
							return null;
						}
						[Token(Token = "0x600236F")]
						[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
						set
						{
						}
					}

					[Token(Token = "0x6002369")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Timed()
					{
					}

					[Token(Token = "0x600236A")]
					[Address(RVA = "0x980880", Offset = "0x97FC80", VA = "0x180980880")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Timed(Timed other)
					{
					}

					[Token(Token = "0x600236B")]
					[Address(RVA = "0x980450", Offset = "0x97F850", VA = "0x180980450", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Timed Clone()
					{
						return null;
					}

					[Token(Token = "0x6002370")]
					[Address(RVA = "0x980560", Offset = "0x97F960", VA = "0x180980560", Slot = "0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x6002371")]
					[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(Timed other)
					{
						return default(bool);
					}

					[Token(Token = "0x6002372")]
					[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x6002373")]
					[Address(RVA = "0x980720", Offset = "0x97FB20", VA = "0x180980720", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x6002374")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6002375")]
					[Address(RVA = "0x940E90", Offset = "0x940290", VA = "0x180940E90", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6002376")]
					[Address(RVA = "0x980390", Offset = "0x97F790", VA = "0x180980390", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6002377")]
					[Address(RVA = "0x980610", Offset = "0x97FA10", VA = "0x180980610", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(Timed other)
					{
					}

					[Token(Token = "0x6002378")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6002379")]
					[Address(RVA = "0x980A30", Offset = "0x97FE30", VA = "0x180980A30", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}

				[Token(Token = "0x2000371")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class Craft : IMessage<Craft>, IMessage, IEquatable<Craft>, IDeepCloneable<Craft>, IBufferMessage
				{
					[Token(Token = "0x4000BD0")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<Craft> _parser;

					[Token(Token = "0x4000BD1")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x4000BD2")]
					public const int ProbabilityFieldNumber = 1;

					[Token(Token = "0x4000BD3")]
					[FieldOffset(Offset = "0x18")]
					private int probability_;

					[Token(Token = "0x1700079E")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<Craft> Parser
					{
						[Token(Token = "0x6002396")]
						[Address(RVA = "0x969930", Offset = "0x968D30", VA = "0x180969930")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x1700079F")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6002397")]
						[Address(RVA = "0x9698B0", Offset = "0x968CB0", VA = "0x1809698B0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170007A0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6002398")]
						[Address(RVA = "0x969980", Offset = "0x968D80", VA = "0x180969980", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170007A1")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int Probability
					{
						[Token(Token = "0x600239C")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x600239D")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x6002399")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Craft()
					{
					}

					[Token(Token = "0x600239A")]
					[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Craft(Craft other)
					{
					}

					[Token(Token = "0x600239B")]
					[Address(RVA = "0x969640", Offset = "0x968A40", VA = "0x180969640", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public Craft Clone()
					{
						return null;
					}

					[Token(Token = "0x600239E")]
					[Address(RVA = "0x9696C0", Offset = "0x968AC0", VA = "0x1809696C0", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x600239F")]
					[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public bool Equals(Craft other)
					{
						return default(bool);
					}

					[Token(Token = "0x60023A0")]
					[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x60023A1")]
					[Address(RVA = "0x969750", Offset = "0x968B50", VA = "0x180969750", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x60023A2")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x60023A3")]
					[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x60023A4")]
					[Address(RVA = "0x9695B0", Offset = "0x9689B0", VA = "0x1809695B0", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x60023A5")]
					[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(Craft other)
					{
					}

					[Token(Token = "0x60023A6")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x60023A7")]
					[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x4000BB6")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<SkillAction> _parser;

			[Token(Token = "0x4000BB7")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000BB8")]
			public const int SkillIdFieldNumber = 1;

			[Token(Token = "0x4000BB9")]
			[FieldOffset(Offset = "0x18")]
			private int skillId_;

			[Token(Token = "0x4000BBA")]
			public const int TimedFieldNumber = 2;

			[Token(Token = "0x4000BBB")]
			public const int CraftFieldNumber = 3;

			[Token(Token = "0x4000BBC")]
			[FieldOffset(Offset = "0x20")]
			private object action_;

			[Token(Token = "0x4000BBD")]
			[FieldOffset(Offset = "0x28")]
			private ActionOneofCase actionCase_;

			[Token(Token = "0x1700078D")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<SkillAction> Parser
			{
				[Token(Token = "0x600234D")]
				[Address(RVA = "0x97F7F0", Offset = "0x97EBF0", VA = "0x18097F7F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700078E")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600234E")]
				[Address(RVA = "0x97F770", Offset = "0x97EB70", VA = "0x18097F770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700078F")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600234F")]
				[Address(RVA = "0x97FBC0", Offset = "0x97EFC0", VA = "0x18097FBC0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000790")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int SkillId
			{
				[Token(Token = "0x6002353")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6002354")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x17000791")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.Timed Timed
			{
				[Token(Token = "0x6002355")]
				[Address(RVA = "0x97F840", Offset = "0x97EC40", VA = "0x18097F840")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002356")]
				[Address(RVA = "0x926590", Offset = "0x925990", VA = "0x180926590")]
				set
				{
				}
			}

			[Token(Token = "0x17000792")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public Types.Craft Craft
			{
				[Token(Token = "0x6002357")]
				[Address(RVA = "0x97F710", Offset = "0x97EB10", VA = "0x18097F710")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002358")]
				[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
				set
				{
				}
			}

			[Token(Token = "0x17000793")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public ActionOneofCase ActionCase
			{
				[Token(Token = "0x6002359")]
				[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
				get
				{
					return default(ActionOneofCase);
				}
			}

			[Token(Token = "0x6002350")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SkillAction()
			{
			}

			[Token(Token = "0x6002351")]
			[Address(RVA = "0x97F490", Offset = "0x97E890", VA = "0x18097F490")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SkillAction(SkillAction other)
			{
			}

			[Token(Token = "0x6002352")]
			[Address(RVA = "0x97ED20", Offset = "0x97E120", VA = "0x18097ED20", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SkillAction Clone()
			{
				return null;
			}

			[Token(Token = "0x600235A")]
			[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void ClearAction()
			{
			}

			[Token(Token = "0x600235B")]
			[Address(RVA = "0x97EE50", Offset = "0x97E250", VA = "0x18097EE50", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x600235C")]
			[Address(RVA = "0x97ED80", Offset = "0x97E180", VA = "0x18097ED80", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(SkillAction other)
			{
				return default(bool);
			}

			[Token(Token = "0x600235D")]
			[Address(RVA = "0x97EF60", Offset = "0x97E360", VA = "0x18097EF60", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x600235E")]
			[Address(RVA = "0x97F330", Offset = "0x97E730", VA = "0x18097F330", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600235F")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6002360")]
			[Address(RVA = "0x97FA90", Offset = "0x97EE90", VA = "0x18097FA90", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6002361")]
			[Address(RVA = "0x97EBB0", Offset = "0x97DFB0", VA = "0x18097EBB0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6002362")]
			[Address(RVA = "0x97F0B0", Offset = "0x97E4B0", VA = "0x18097F0B0", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(SkillAction other)
			{
			}

			[Token(Token = "0x6002363")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6002364")]
			[Address(RVA = "0x97F8A0", Offset = "0x97ECA0", VA = "0x18097F8A0", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000BAF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobDescription> _parser;

	[Token(Token = "0x4000BB0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000BB1")]
	public const int JobIdFieldNumber = 1;

	[Token(Token = "0x4000BB2")]
	[FieldOffset(Offset = "0x18")]
	private int jobId_;

	[Token(Token = "0x4000BB3")]
	public const int SkillsFieldNumber = 2;

	[Token(Token = "0x4000BB4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Types.SkillAction> _repeated_skills_codec;

	[Token(Token = "0x4000BB5")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Types.SkillAction> skills_;

	[Token(Token = "0x17000788")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JobDescription> Parser
	{
		[Token(Token = "0x6002339")]
		[Address(RVA = "0x971520", Offset = "0x970920", VA = "0x180971520")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000789")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600233A")]
		[Address(RVA = "0x971470", Offset = "0x970870", VA = "0x180971470")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700078A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600233B")]
		[Address(RVA = "0x971770", Offset = "0x970B70", VA = "0x180971770", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700078B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int JobId
	{
		[Token(Token = "0x600233F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002340")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700078C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Types.SkillAction> Skills
	{
		[Token(Token = "0x6002341")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600233C")]
	[Address(RVA = "0x971360", Offset = "0x970760", VA = "0x180971360")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobDescription()
	{
	}

	[Token(Token = "0x600233D")]
	[Address(RVA = "0x9713E0", Offset = "0x9707E0", VA = "0x1809713E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobDescription(JobDescription other)
	{
	}

	[Token(Token = "0x600233E")]
	[Address(RVA = "0x970E00", Offset = "0x970200", VA = "0x180970E00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobDescription Clone()
	{
		return null;
	}

	[Token(Token = "0x6002342")]
	[Address(RVA = "0x970EC0", Offset = "0x9702C0", VA = "0x180970EC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002343")]
	[Address(RVA = "0x970FA0", Offset = "0x9703A0", VA = "0x180970FA0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobDescription other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002344")]
	[Address(RVA = "0x971040", Offset = "0x970440", VA = "0x180971040", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002345")]
	[Address(RVA = "0x971160", Offset = "0x970560", VA = "0x180971160", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002346")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002347")]
	[Address(RVA = "0x9716A0", Offset = "0x970AA0", VA = "0x1809716A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002348")]
	[Address(RVA = "0x970D20", Offset = "0x970120", VA = "0x180970D20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002349")]
	[Address(RVA = "0x9710D0", Offset = "0x9704D0", VA = "0x1809710D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobDescription other)
	{
	}

	[Token(Token = "0x600234A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600234B")]
	[Address(RVA = "0x971570", Offset = "0x970970", VA = "0x180971570", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
